//using BusinessEnteties.models;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;
//using Microsoft.EntityFrameworkCore;

//namespace DataLayer.models
//{
//    class AdministratörRepository : GenericRepository<Administratör>, IAdministratörRepository
//    {
//        private readonly DbContext db;
        
//        public AdministratörRepository(DbContext db) : base(db)
//        {
//            this.db = db;
//        }

//        public void Add(Administratör entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void AddRange(IEnumerable<Administratör> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public Administratör Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Administratör> GetAll()
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

//        public DatabaseContext DatabaseContext 
//        {
//            get { return Context as DatabaseContext; }
//        }
//    }
//}
