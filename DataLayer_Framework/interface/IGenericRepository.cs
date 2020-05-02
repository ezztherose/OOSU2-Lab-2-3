using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(int id);

        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity, int id);

        ObservableCollection<T> GetObservableCollection();
    }
}
