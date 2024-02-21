using GreenSaleMVC.Models;

namespace GreenSaleMVC.Data.Interfaces
{
    public interface ICategoryInterface
    {
        void Create(Category category);
        List<Category> GetAll();
    }
}
