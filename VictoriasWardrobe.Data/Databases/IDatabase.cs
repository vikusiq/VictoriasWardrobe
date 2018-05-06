using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Databases
{
    public interface IDatabase
    {
        Type GetDatabaseType();
    }
}
