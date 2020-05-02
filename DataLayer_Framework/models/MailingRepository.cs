using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_Framework.models
{
    public class MailingRepository : GenericRepository<Mailing>, IMailingRepository
    {
        public MailingRepository(DatabaseContext db) : base(db)
        {

        }

        public DatabaseContext DBcontext { get; set; }
        public Mailing mailing { get; set; }

        public List<Alumn> SökLista(string value)
        {

            using (var db = new DatabaseContext())
            {
                return db.Alumner.Where(x => x.Namn.ToLower().Contains(value)).ToList();
            }
        }

        public List<Alumn> HämtaTillgängligaAlumner(Mailing m)
        {
            using (var db = new DatabaseContext())
            {
                var alumn = db.Alumner.Where(a => a.mailings.Any(mm => mm.ID == m.ID));
                return alumn.ToList();
            }
        }
    }
}
