using System.Linq.Expressions;

namespace Interfaces
{
    public interface IAccessorRepository<TEntity, TEntityID> where TEntity : class where TEntityID : struct
    {
        IQueryable<TEntity> Get();

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetAsync();

        Task<ICollection<TEntity>> GetOrderByAsync();

        Task<ICollection<TEntity>> GetOrderByDescendingAsync();

        Task<TEntity> FindAsync(TEntityID id);

        Task<bool> SuccessAsync(TEntityID id);

        Task<bool> SuccessAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
