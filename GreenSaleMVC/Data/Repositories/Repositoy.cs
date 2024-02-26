using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenSaleMVC.Data.Repositories
{
    public class Repositoy<TEntity>(AppDbContext dbcontext) : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _dbcontext = dbcontext;
        private readonly DbSet<TEntity> _dbset = dbcontext.Set<TEntity>();
        public void Add(TEntity entity)
        {
            _dbset.Add(entity);
            _dbcontext.SaveChanges();   

        }

        public void Delete(int id)
        {
            var entity = _dbset.FirstOrDefault(x => x.Id== id);
            if (entity!=null)
            {
                _dbset.Remove(entity);
            }
            _dbcontext.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _dbset.ToList();

        }

        public TEntity GetById(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

        public void Update(TEntity entity)
        {
            _dbset.Update(entity);
            _dbcontext.SaveChanges();
        }
    }
}
