using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Infrastructure
{
    public interface IDatabaseFactory
    {
        DbContext Get(Type databaseType);
    }
}
