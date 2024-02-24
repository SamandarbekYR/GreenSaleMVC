using GreenSaleMVC.Data.Entities.Categories;

namespace GreenSaleMVC.Data.Interfaces
{
    public interface ICategoryInterface
    {
        void Create(Category category);
        List<Category> GetAll();
        void Update(Category category, int id);

        
    }
}
