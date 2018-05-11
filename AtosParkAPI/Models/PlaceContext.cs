using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AtosParkAPI.Models
{
    public class PlaceContext : DbContext
    {
        public PlaceContext() : base("name=Place")
        {

        }
        public DbSet<Place> Places { get; set; }

    }
}