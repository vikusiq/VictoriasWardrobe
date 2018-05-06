using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriasWardrobe.Data.Contexts;
using VictoriasWardrobe.Data.Infrastructure;

namespace VictoriasWardrobe.Data.Databases
{
    public class VictoriasWardrobeDatabaseFactory : IDatabaseFactory
    {
        private DbContext victoriasWardrobeContext;

        public void Dispose()
        {
            victoriasWardrobeContext?.Dispose();
        }

        public DbContext Get(Type databaseType)
        {
            if (typeof(VictoriasWardrobeContext) == databaseType)
                return victoriasWardrobeContext ?? (victoriasWardrobeContext = new VictoriasWardrobeContext());

            return null;
        }
    }
}





