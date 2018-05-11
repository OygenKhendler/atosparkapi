using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AtosParkAPI.Models
{
    public class PlaceDbInitializer : DropCreateDatabaseAlways<PlaceContext>
    {
        protected override void Seed(PlaceContext db)
        {
            db.Places.Add(new Place { _PlaceNumber = "40", _Avaiable = true });
            db.Places.Add(new Place { _PlaceNumber = "41", _Avaiable = true });
            db.Places.Add(new Place { _PlaceNumber = "42", _Avaiable = true });
            db.Places.Add(new Place { _PlaceNumber = "43", _Avaiable = true });
            db.Places.Add(new Place { _PlaceNumber = "44", _Avaiable = true });

            base.Seed(db);
        }
    }
}