using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using AtosParkAPI.Models;

namespace AtosParkAPI.Controllers
{
    public class ValuesController : ApiController
    {
        PlaceContext PlaceDb = new PlaceContext();
        // GET api/values
        public IEnumerable<Place> GetPlaces()
        {
            return PlaceDb.Places;
        }

        // GET api/values/5
        public Place GetPlace(int id)
        {
            Place place = PlaceDb.Places.Find(id);
            return place;
            
            
        }

        [HttpPost]
        public void AddPlace([FromBody]Place place)
        {
            PlaceDb.Places.Add(place);
            PlaceDb.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Place place)
        {
            if (id == place._PlaceID)
            {
                PlaceDb.Entry(place).State = EntityState.Modified;

                PlaceDb.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Place place = PlaceDb.Places.Find(id);
            PlaceDb.Places.Remove(place);
            PlaceDb.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                PlaceDb.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
