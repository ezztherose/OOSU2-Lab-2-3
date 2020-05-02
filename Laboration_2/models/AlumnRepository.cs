//using BusinessEnteties.models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataLayer.models
//{
//    public class AlumnRepository : GenericRepository<Alumn>, IAlumnRepository
//    {
//        // FEL
//        // Skrota och lägg i databasen
//        private readonly DbContext db;
//        // LÖSNING: Added - DbContext db, base(db)
//        public AlumnRepository(DbContext db) : base(db)
//        {
//            this.db = db;
//        }


//        public void Add(Alumn _a)
//        {
//            using (var db = new DatabaseContext())
//            {
//                db.Alumner.Add(_a);
//                db.SaveChanges();
//            }
//        }


//        public List<Alumn> GetAll()
//        {


//                return null;
//        }

//        public Alumn Get(int id)
//        {
//            using (var db = new DatabaseContext())
//            {
                  
//            }

//            return null;
//        }





//        public DatabaseContext DatabaseContext
//        {
//            get { return Context as DatabaseContext; }
//        }
//    }
//}
