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
        public void Update(Category category, int id)
        {
            var CategotyId = dbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (CategotyId == null)
            {
                throw new Exception("Bunday id yoq");
            }
            dbContext.Categories.Update(category);
            dbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }
    }
}
