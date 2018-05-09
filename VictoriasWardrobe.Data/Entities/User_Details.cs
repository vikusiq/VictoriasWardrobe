using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class User_Details
    {
        [Key]
        public int user_id { get; set; }
        public char gender { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public float shoes_size{ get; set; }
        public string clothes_size{ get; set; }
        public float balance { get; set; }
        public int phone_number{ get; set; }
        public DateTime date_of_birth { get; set; }

    }
}
