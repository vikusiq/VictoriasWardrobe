using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class Shopping_cart
    {
        [Key]
        public int user_id { get; set; }
        public int product_id { get; set; }
    }
}
