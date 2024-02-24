using GreenSaleMVC.Data.Entities;

namespace GreenSaleMVC.Data.Interfaces
{
    public interface IRepository <TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity? GetById(Guid id);
        int Remove(Guid id);
        int Update(TEntity entity, Guid id);
        ValueTask<int> Add(TEntity entity);
    }
}
