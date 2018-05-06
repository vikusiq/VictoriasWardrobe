using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriasWardrobe.Data.Contexts;

namespace VictoriasWardrobe.Data.Databases
{
    public class VictoriasWardrobeDatabase : IDatabase
    {
        public Type GetDatabaseType()
        {
            return typeof(VictoriasWardrobeContext);
        }
    }
}
