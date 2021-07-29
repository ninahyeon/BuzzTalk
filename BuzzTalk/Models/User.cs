using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuzzTalk.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string user_ID { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string birth_DT { get; set; }
        [Required]
        public DateTime registration_DT { get; set; }
    }
}
