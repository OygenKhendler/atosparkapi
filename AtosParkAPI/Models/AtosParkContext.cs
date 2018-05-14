using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AtosParkAPI.Models
{
    public class AtosParkContext : DbContext
    {
        public AtosParkContext() 
            : base("AtosParkContext")
        {

            Database.CommandTimeout = 300;
            Database.SetInitializer(new AtosParkDbInitializer());
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }


    }
}