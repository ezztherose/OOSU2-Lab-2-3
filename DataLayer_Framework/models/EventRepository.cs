using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using DataLayer;
using DataLayer.models;
using DataLayer_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_Framework.models
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(DatabaseContext context) : base(context)
        {

        }

        public void LäggTillAlumn(Alumn a)
        {
            using (var db = new DatabaseContext())
            {
                
            }
        }

        public DatabaseContext DBcontext { get; set; }
        public Event Event { get; set; }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public void CreateEvent(Event e, Personal p)
        {
            if (p != null)
            {
                e.p = DatabaseContext.Personal.Where(x => x.ID == p.ID).FirstOrDefault();
            }            

            DatabaseContext.Event.Add(e);
            DatabaseContext.SaveChanges(); 
        }

        public List<Event> SearchEvent (string search)
        {
            using (var db = new DatabaseContext())
            {
                return db.Event.Where(x => x.Namn.ToLower().Contains(search)).ToList();
            }
        }

        public void RegistreraTillEvent(Alumn a, int id, Event e)
        {
            e.EventAlumner.Add(a);
        }

        public List<Alumn> HämtaEventetsAlumner(Event e)
        {
            using(var db = new DatabaseContext())
            {
                var alumn = db.Alumner.Where(a => a.events.Any(ev => ev.ID == e.ID));
                return alumn.ToList();
            }
        }
    }
}
