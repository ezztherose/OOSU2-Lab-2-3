using BusinessEnteties.models;
using BusinessEntities_Framework;
using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_Framework.models
{
    public class JobbRepository : GenericRepository<Jobb>, IJobbRepository
    {
        public JobbRepository(DatabaseContext db) : base(db)
        { 

        }

        public DatabaseContext DBcontext { get; set; }
        public Jobb jobb { get; set; }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public List<Alumn> HämtaJobbAlumner(Jobb j)
        {
            using (var db = new DatabaseContext())
            {
                var alumn = db.Alumner.Where(a => a.JobbAlumn.Any(mm => mm.ID == j.ID));
                return alumn.ToList();
            }
        }

        public List <Jobb> SearchJob(string j)
        {
            using(var db = new DatabaseContext())
            {
                return db.Jobb.Where(x => x.Titel.ToLower().Contains(j)).ToList();
            }
        }

    }
}
