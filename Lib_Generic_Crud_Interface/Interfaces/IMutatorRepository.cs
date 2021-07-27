using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMutatorRepository<T> where T : class
    {
        Task AddAsync(T t);
        void Remove(T t);
        void Update(T t);
    }
}
