using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataLayer.models
{
    public class PersonalRepository : GenericRepository<Personal>, IPersonalRepository
    {
        public PersonalRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }

        public DatabaseContext DBcontext { get; set; }
        public Personal personal { get; set; }

        public Personal LoggIn(string användarnamn, string password)
        {
            using (var db = new DatabaseContext())
            {
                return db.Personal.Where(x => x.AnvändarNamn.ToLower() == användarnamn.ToLower() && x.Password == password.ToLower()).FirstOrDefault();
            }
        }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
    }
}
