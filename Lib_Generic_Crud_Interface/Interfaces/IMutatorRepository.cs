using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMutatorRepository<TEntity> where TEntity : class
    {
        Task PostRangeAsync(TEntity entity);

        Task PutRangeAsync(TEntity entity);

        Task DeleteRangeAsync(TEntity entity);
    }
}
