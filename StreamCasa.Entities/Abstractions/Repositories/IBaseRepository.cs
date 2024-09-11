using StreamCasa.Abstractions.Entities;

namespace StreamCasa.Entities.Abstractions.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity:IEntity
    {
        Task<TEntity> AddOrUpdate(TEntity user);
        Task<TEntity> Delete(TEntity user);
    }
}
