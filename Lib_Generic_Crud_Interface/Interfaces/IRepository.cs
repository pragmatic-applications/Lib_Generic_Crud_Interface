namespace Interfaces
{
    public interface IRepository<TEntity, TEntityID> : IAccessorRepository<TEntity, TEntityID>, IMutatorRepository<TEntity> where TEntity : class where TEntityID : struct
    {
    }
}
