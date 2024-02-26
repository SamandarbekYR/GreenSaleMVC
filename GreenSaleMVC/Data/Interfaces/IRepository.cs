using GreenSaleMVC.Models;

namespace GreenSaleMVC.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {

        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
