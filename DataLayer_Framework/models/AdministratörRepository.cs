using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Linq;

namespace DataLayer.models
{
    public class AdministratörRepository : GenericRepository<Administratör>, IAdministratörRepository
    {
        public AdministratörRepository(DatabaseContext db) : base(db)
        {
            
        }
        
        public DatabaseContext DBcontext { get; set; }
        public Administratör administratör { get; set; }

        public Administratör LoggIn(string användarnamn, string password)
        {
            using (var db = new DatabaseContext())
            {
                return db.Administratörer.Where(x => x.AnvändarNamn.ToLower() == användarnamn.ToLower() && x.Password.ToLower() == password.ToLower()).FirstOrDefault();
            }
        }
    }
}
