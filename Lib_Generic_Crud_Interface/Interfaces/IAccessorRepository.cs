using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAccessorRepository<T> where T : class
    {
        IQueryable<T> Get();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);

        Task<ICollection<T>> GetOrderByAsync();
        Task<ICollection<T>> GetOrderByDescendingAsync();
        Task<T> FindEntityAsync(int id);
        Task<T> FirstOrDefaultWhereAsync(Expression<Func<T, bool>> predicate);
    }

    public interface IAccessorRepository<T, TID> where T : class where TID : struct
    {
        IQueryable<T> Get();
        IQueryable<T> Get(TID id);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);

        Task<ICollection<T>> GetOrderByAsync();
        Task<ICollection<T>> GetOrderByDescendingAsync();
        Task<T> FindEntityAsync(int id);
        Task<T> FirstOrDefaultWhereAsync(Expression<Func<T, bool>> predicate);
    }
}
