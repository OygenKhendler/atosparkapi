namespace AtosParkAPI.Migrations
{
    using AtosParkAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtosParkAPI.Models.AtosParkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AtosParkAPI.Models.AtosParkContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //var places = new List<Place>
            //{
            //    new Place { PlaceNumber = "40", Avaiable = true },
            //    new Place { PlaceNumber = "41", Avaiable = true },
            //    new Place { PlaceNumber = "42", Avaiable = true },
            //    new Place { PlaceNumber = "43", Avaiable = true },
            //    new Place { PlaceNumber = "44", Avaiable = true },
            //};
            //places.ForEach(s => context.Places.AddOrUpdate(p => p.PlaceId, s));
            //context.SaveChanges();



        }
    }
}
