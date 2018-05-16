using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AtosParkAPI.Models
{
    public class AtosParkDbInitializer : DropCreateDatabaseIfModelChanges<AtosParkContext>
    {
        protected override void Seed(AtosParkContext db)
        {
            db.Places.Add(new Place { PlaceNumber = "40", Avaiable = true });
            db.Places.Add(new Place { PlaceNumber = "41", Avaiable = true });
            db.Places.Add(new Place { PlaceNumber = "42", Avaiable = true });
            db.Places.Add(new Place { PlaceNumber = "43", Avaiable = true });
            db.Places.Add(new Place { PlaceNumber = "44", Avaiable = true });
            db.SaveChanges();
            base.Seed(db);
        }
    }
}