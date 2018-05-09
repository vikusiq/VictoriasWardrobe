using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriasWardrobe.Data.Entities
{
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        public string email_address { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool administrator { get; set; }
    }
}
