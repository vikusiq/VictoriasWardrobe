using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriasWardrobe.Data.Entities;

namespace VictoriasWardrobe.Data.Contexts
{
    public class VictoriasWardrobeContext : DbContext
    {
        private const string ConnectionStringName = "Data Source=DESKTOP-US4FEKS;Initial Catalog=VictoriasWardrobe;Integrated Security=True";

        public VictoriasWardrobeContext() :base(ConnectionStringName)
        {
            Database.SetInitializer<VictoriasWardrobeContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Shopping_cart> ShoppingCart { get; set; }
        public virtual DbSet<User_Details> UserDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }
       
    }
}
