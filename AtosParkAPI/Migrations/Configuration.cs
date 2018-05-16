namespace AtosParkAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AtosParkAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AtosParkAPI.Models.AtosParkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AtosParkAPI.Models.AtosParkContext";
        }

        protected override void Seed(AtosParkAPI.Models.AtosParkContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
