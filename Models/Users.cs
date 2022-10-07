using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test111binimoy.Models
{
    public class Users
    {
        public int Id { get; set; }
       
        [Required]
        public string email { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string Password { get; set; }
      

    }
}