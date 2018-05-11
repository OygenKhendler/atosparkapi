using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtosParkAPI.Models
{
    public class User
    {
        public int _UserID { get; set; }
        public string _CarNumber  { get; set; }
        public string _Password { get; set; }
        public virtual Place Place { get; set; }

        
    }
}