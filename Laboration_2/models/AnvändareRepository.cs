//using BusinessEnteties.models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataLayer.models
//{
//    class AnvändareRepository : GenericRepository<Användare>, IAdministratörRepository
//    {
//        public AnvändareRepository(DbContext context) : base(context)
//        {

//        }

//        public void Add(Administratör entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void AddRange(IEnumerable<Administratör> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public void Remove(Administratör entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveRange(IEnumerable<Administratör> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public Administratör SingleOrDefault(Expression<Func<Administratör, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        Administratör IGenericRepository<Administratör>.Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerable<Administratör> IGenericRepository<Administratör>.GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public DatabaseContext DatabaseContext
//        {
//            get { return Context as DatabaseContext; }
//        }
//    }
//}
