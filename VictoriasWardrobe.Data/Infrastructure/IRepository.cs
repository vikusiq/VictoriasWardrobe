using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VictoriasWardrobe.Data.Databases;

namespace VictoriasWardrobe.Data.Infrastructure
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        List<TResult> ExecuteQuery<TResult>(string sqlQuery, params object[] parameters);
        IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includeProperties);
    };

    public interface IRepository<TEntity, TDatabase> : IRepositoryBase<TEntity> where TEntity : class where TDatabase : IDatabase
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void RefreshEntity(TEntity entity);
        TEntity GetByKey(TEntity entity);
        TEntity GetById(int id);

        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);
        int Count();
        int Count(Expression<Func<TEntity, bool>> where);
        List<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        void ExecuteCommand(string sqlQuery, params object[] parameters);
    }
}



