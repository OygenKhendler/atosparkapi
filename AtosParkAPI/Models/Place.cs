using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AtosParkAPI.Models
{
    [Table("Places")]
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }
        public string PlaceNumber { get; set; }
        public bool Avaiable { get; set; }
        
        public int? UserID { get; set; }
        
        [ForeignKey(nameof(UserID))]
        public virtual User User { get; set; }

    }
    
}