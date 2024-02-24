using GreenSaleMVC.Data.Entities;
using GreenSaleMVC.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenSaleMVC.Data.Repositories
{
    public class Repository<TEntity>(AppDbContext appDb)
        : IRepository<TEntity> where TEntity : BaseEntity
    {
        public AppDbContext _dbContext = appDb;
        public DbSet<TEntity> _dbSet = appDb.Set<TEntity>();
        
        public async ValueTask<int> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public TEntity? GetById(Guid id)
        {
            TEntity? entity = _dbSet.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return null;
            }

            return entity;
        }

        public int Remove(Guid id)
        {
            TEntity? entity = GetById(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
                return _dbContext.SaveChanges();
            }

            return 0;
        }

        public int Update(TEntity entity, Guid id)
        {
            TEntity? model = GetById(id);

            if (model != null)
            {
                _dbSet.Update(entity);
                return _dbContext.SaveChanges();
            }

            return 0;
        }
    }
}
