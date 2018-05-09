using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string size { get; set; }
        public int discount { get; set; }
        public int for_what_age { get; set; }
        public bool second_hand { get; set; }
        public bool IsAvalable { get; set; }
        public int user_id { get; set; }
        public int category_id { get; set; }
        public int color_id{ get; set; }
        public int brand_id { get; set; }

    }
}
