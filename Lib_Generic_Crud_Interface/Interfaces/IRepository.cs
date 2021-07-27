namespace Interfaces
{
    public interface IRepository<T> : IAccessorRepository<T>, IMutatorRepository<T>, ISuccess where T : class
    {
    }

    public interface IRepository<T, TID> : IAccessorRepository<T>, IMutatorRepository<T>, ISuccess<T> where T : class where TID : struct
    {
    }
}
