using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosParkAPI.Models
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        public string CarNumber  { get; set; }
       // public string Password { get; set; }
       
        public string Url { get; set; }
    }
}