using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class Color
    {
        [Key]
        public string color_id { get; set; }
        public string color_name { get; set; }
  
    }
}
