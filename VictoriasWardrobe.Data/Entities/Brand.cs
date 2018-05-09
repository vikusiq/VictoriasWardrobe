using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class Brand
    {
        [Key]
        public int brand_id { get; set; }

        public string brand_name { get; set; }
    }
}
