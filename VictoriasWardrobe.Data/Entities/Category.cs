using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    
    public class Category
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}
