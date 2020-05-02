//using BusinessEnteties.models;
//using DataLayer.models;
//using System;
//using System.Collections.Generic;
//using System.Text;


//namespace DataLayer.UnitToWork
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly DatabaseContext _context;

//        public UnitOfWork(DatabaseContext context)
//        {
//            _context = context;

//            Alumn = new AlumnRepository(_context);
//            Administratör = new AdministratörRepository(_context);
//            Personal = new PersonalRepository(_context);
//            Student = new StudentRepository(_context);
//        }

//        public IAlumnRepository Alumn { get; private set; }

//        public IAdministratörRepository Administratör { get; private set; }

//        public IPersonalRepository Personal { get; private set; }

//        public IStudentRepository Student { get; private set; }

//        /// <summary>
//        /// Spara ändringar som görs
//        /// </summary>
//        /// <returns></returns>
//        public int Complete()
//        {
//            return _context.SaveChanges();
//        }

//        public void Dispose()
//        {
//            _context.Dispose();
//        }
//    }
//}
