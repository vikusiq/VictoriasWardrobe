using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class Images
    { 
        [Key]
        public string image_url { get; set; }
        public int product_id { get; set; }
    }
}
