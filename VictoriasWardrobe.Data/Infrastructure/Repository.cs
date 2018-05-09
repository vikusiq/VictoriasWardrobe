using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using VictoriasWardrobe.Data.Databases;

namespace VictoriasWardrobe.Data.Infrastructure
{
    public class Repository<TEntity, TDatabase> : IRepository<TEntity, TDatabase>
        where TEntity : class
        where TDatabase : IDatabase
    {

        private readonly DbContext dataContext;
        private readonly IDbSet<TEntity> dbset;

        public Repository(IDatabaseFactory databaseFactory)
        {
            var database = (TDatabase)Activator.CreateInstance(typeof(TDatabase)); 
            var databaseType = database.GetDatabaseType();
            dataContext = databaseFactory.Get(databaseType);
            dbset = dataContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            dbset.Remove(entity);
        }

        private string[] GetKeyNames()
        {
            var objectSet = ((IObjectContextAdapter)dataContext).ObjectContext.CreateObjectSet<TEntity>();
            var keyNames = objectSet.EntitySet.ElementType.KeyMembers.Select(k => k.Name).ToArray();
            return keyNames;
        }

        private object[] GetKeys(TEntity entity)
        {
            var keyNames = GetKeyNames();
            var type = typeof(TEntity);

            var keys = new object[keyNames.Length];
            for (var i = 0; i < keyNames.Length; i++)
            {
                keys[i] = type.GetProperty(keyNames[i]).GetValue(entity, null);
            }
            return keys;
        }

        public virtual TEntity GetByKey(TEntity entity)
        {
            var keys = GetKeys(entity);
            return dbset.Find(keys);
        }
        public virtual TEntity GetById(int id)
        {
            return dbset.Find(id);
        }

        public IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = dbset;

            foreach (var includeProperty in includeProperties)
                query = query.Include(includeProperty);

            return query;
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Query(includeProperties).Where(where);
        }


        public int Count()
        {
            return dbset.Count();
        }

        public int Count(Expression<Func<TEntity, bool>> where)
        {
            return dbset.Count(where);
        }

        public List<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return dbset.Where(where).ToList();
        }

        public List<TResult> ExecuteQuery<TResult>(string sqlQuery, params object[] parameters)
        {
            return ((IObjectContextAdapter)dataContext).ObjectContext.ExecuteStoreQuery<TResult>(sqlQuery, parameters).ToList();
        }

        public void ExecuteCommand(string sqlQuery, params object[] parameters)
        {
            ((IObjectContextAdapter)dataContext).ObjectContext.ExecuteStoreCommand(sqlQuery, parameters);
        }

        public void RefreshEntity(TEntity entity)
        {
            dataContext.Entry<TEntity>(entity).Reload();
        }
    }
}
