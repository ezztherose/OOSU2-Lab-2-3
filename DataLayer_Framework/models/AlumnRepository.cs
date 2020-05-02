using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer.models
{
    public class AlumnRepository : GenericRepository<Alumn>, IAlumnRepository
    {
        public AlumnRepository(DatabaseContext db) : base(db)
        {
            
        }

        public DatabaseContext DBcontext { get; set; }
        public Alumn alumn { get; set; }

        public Alumn LoggIn(string användarnamn, string password)
        {
            using (var db = new DatabaseContext())
            {
                return db.Alumner.Where(x => x.AnvändarNamn.ToLower() == användarnamn.ToLower() && x.Password.ToLower() == password.ToLower()).SingleOrDefault();
            }
        }           

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public List<Alumn> SearchAlumn(string value)
        {
            using (var db = new DatabaseContext())
            {
                return db.Alumner.Where(x => x.Utbildning.ToLower().Contains(value)).ToList();
            }
        }

        public void RegistreraTillEvent(Alumn alumn, int id, Event e)
        {
            Event existing = Context.Set<Event>().Find(e.ID);

            if (existing != null)
            {
                alumn.events.Add(e);
                Context.SaveChanges();
            }
        }
    }
}
