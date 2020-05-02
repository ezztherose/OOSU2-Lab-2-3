//using BusinessEnteties.models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;


//namespace DataLayer
//{
//    public class GenericRepository<T> : IGenericRepository<T> where T : class
//    {
//        // Lägg till db context
//        protected readonly DbContext Context;

//        public GenericRepository(DbContext context) : base()
//        {
//            Context = context;
//        }

//        public DbContext DbContext { get; }


//        /// <summary>
//        /// Skickar in en typ som skall läggas till
//        /// databasen.
//        /// </summary>
//        /// <param name="entity"></param>
//        public void Add(T entity)
//        {
//            //throw new NotImplementedException();
//            Context.Set<T>().Add(entity);
//        }

//        /// <summary>
//        /// Tar emot en lista av en typ och lägger till
//        /// databasen
//        /// </summary>
//        /// <param name="entities"></param>
//        public void AddRange(IEnumerable<T> entities)
//        {
//            Context.Set<T>().AddRange(entities);
//        }

//        /// <summary>
//        /// Sickar in ett id och hämtar motsvarande
//        /// objekttyp 
//        /// </summary>
//        /// <param name="id"></param>
//        /// <returns>
//        /// Ett objekt av en specifik typ
//        /// </returns>
//        public T Get(int id)
//        {
//            return Context.Set<T>().Find(id);
//        }

//        /// <summary>
//        /// Hämnat en hel lista av en typ
//        /// </summary>
//        /// <returns>
//        /// En lista av en typ
//        /// </returns>
//        public IEnumerable<T> GetAll()
//        {
//            return Context.Set<T>().ToList();
//        }

//        /// <summary>
//        /// Tar bort ett specifikt objekt
//        /// av vald typ
//        /// </summary>
//        /// <param name="entity"></param>
//        public void Remove(T entity)
//        {
//            Context.Set<T>().Remove(entity);
//        }

//        /// <summary>
//        /// Tar bort en hel lista från databasen av en
//        /// viss typ
//        /// </summary>
//        /// <param name="entities"></param>
//        public void RemoveRange(IEnumerable<T> entities)
//        {
//            Context.Set<T>().RemoveRange(entities);
//        }

//        public T SingleOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
//        {
//            return Context.Set<T>().SingleOrDefault(predicate);
//        }
//    }
//}
