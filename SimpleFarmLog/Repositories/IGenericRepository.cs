using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SimpleFarmLog.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Delete(T entityToDelete);
        void DeleteByID(object id);
        Task DeleteByIDAsync(object id);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetByID(object id);
        Task<T> GetByIDAsync(object id);
        void Insert(T entity);
        Task InsertAsync(T entity);
        void Update(T entityToUpdate);
    }
}