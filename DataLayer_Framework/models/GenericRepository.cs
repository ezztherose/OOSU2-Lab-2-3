using BusinessEnteties.models;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace DataLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DatabaseContext Context = null;

        public GenericRepository(DatabaseContext context) 
        {
            Context = context;
        }

        public DbContext DbContext { get; }

        private readonly DbSet<T> _entity;

        /// <summary>
        /// Skickar in en typ som skall läggas till
        /// databasen.
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            //throw new NotImplementedException();
            Context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Tar emot en lista av en typ och lägger till
        /// databasen
        /// </summary>
        /// <param name="entities"></param>
        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }

        /// <summary>
        /// Sickar in ett id och hämtar motsvarande
        /// objekttyp 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Ett objekt av en specifik typ
        /// </returns>
        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        /// <summary>
        /// Hämnat en hel lista av en typ
        /// </summary>
        /// <returns>
        /// En lista av en typ
        /// </returns>
        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public ObservableCollection<T> GetObservableCollection()
        {
            ObservableCollection<T> obs = new ObservableCollection<T>();

            foreach (T item in _entity)
            {
                obs.Add(item);
            }

            return obs;
        }

        /// <summary>
        /// Tar bort ett specifikt objekt
        /// av vald typ
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(int id)
        {
            Context.Set<T>().Remove(Get(id));
            Context.SaveChanges();
        }
        /// <summary>
        /// Tar bort en hel lista från databasen av en
        /// viss typ
        /// </summary>
        /// <param name="entities"></param>
        public void RemoveRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }

        public T SingleOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().SingleOrDefault(predicate);
        }

        public void Update(T entity, int id)
        {
            T existing = Context.Set<T>().Find(id);

            if (existing != null)
            {
                Context.Entry(existing).CurrentValues.SetValues(entity);
                Context.SaveChanges();
            }
        }
    }
}
