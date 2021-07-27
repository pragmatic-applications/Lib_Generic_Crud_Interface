using System.Linq.Expressions;
using System;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISuccess
    {
        Task<bool> SuccessAsync(int id);
    }

    public interface ISuccess<T> where T : class
    {
        Task<bool> SuccessAsync(int id);
        Task<bool> SuccessAsync(Expression<Func<T, bool>> predicate);
    }
}
