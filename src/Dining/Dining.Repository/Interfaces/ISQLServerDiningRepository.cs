using Dining.Models.Interfaces;

namespace Dining.Repository.Interfaces
{
    public interface ISQLServerDiningRepository<TEntity> : IDisposable where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(TEntity entity);
        void Delete(TEntity entity);
        void Add(TEntity entity);
    }
}
