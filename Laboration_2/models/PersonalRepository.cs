//using BusinessEnteties.models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataLayer.models
//{
//    public class PersonalRepository : GenericRepository<Person>, IPersonalRepository
//    {
//        // Lösning: Added- DbContext dbcontext, base(dbcontext)

//        public PersonalRepository(DbContext dbContext) : base(dbContext)
//        {

//        }

//        public void Add(Personal entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void AddRange(IEnumerable<Personal> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public Personal Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Personal> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public void Remove(Personal entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveRange(IEnumerable<Personal> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public Personal SingleOrDefault(Expression<Func<Personal, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public DatabaseContext DatabaseContext
//        {
//            get { return Context as DatabaseContext; }
//        }
//    }
//}
