using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtosParkAPI.Models
{
    public class Place
    {
        public int ID { get; set; }
        public string _PlaceNumber { get; set; }
        public bool _Avaiable { get; set; }
        public int? _UserID { get; set; }
        

    }
    
}