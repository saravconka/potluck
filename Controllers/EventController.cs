using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TutsWebAPI.Models;

namespace TutsWebAPI.Controllers
{
    public class EventController : ApiController
    {
        // GET api/event+
        public IEnumerable<Event> Get()
        {
            using (PotluckEntities db = new PotluckEntities()) {
                return db.Events.ToList();
            }
        }

        // GET api/event/5
        public Event Get(int id)
        {
            using (PotluckEntities db = new PotluckEntities())
            {
                return db.Events.FirstOrDefault<Event>(e => e.EventId == id);
            }
        }

        // POST api/event
        public void Post(Event value)
        {
            using (PotluckEntities db = new PotluckEntities()) {
                //Event e = new Event();
                //e.EventName = "Event 1: " + Guid.NewGuid().ToString();

                db.Events.Add(value);
                db.SaveChanges();
            }    
        }

        // PUT api/event/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/event/5
        public void Delete(int id)
        {
        }
    }
}
