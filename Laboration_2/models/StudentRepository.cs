//using BusinessEnteties.models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataLayer.models
//{
//    class StudentRepository : GenericRepository<Student>, IStudentRepository 
//    {
//        private readonly DbContext Context;
//        // LÖSNING: Added - DbContext db, base(db)
//        public StudentRepository(DbContext context) : base(context)
//        {
//            this.Context = context;
//        }

//        public void Add(Student entity)
//        {
            
//        }

//        public void AddRange(IEnumerable<Student> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public Student Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Student> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public void Remove(Student entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveRange(IEnumerable<Student> entities)
//        {
//            throw new NotImplementedException();
//        }

//        public Student SingleOrDefault(Expression<Func<Student, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public DatabaseContext DatabaseContext
//        {
//            get { return Context as DatabaseContext; }
//        }
//    }
//}
