using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.Models;

namespace GreenSaleMVC.Data.Repositories
{
    public class CategoryRepository : ICategoryInterface
    {
        private AppDbContext dbContext;
        public CategoryRepository( AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }
    }
}
