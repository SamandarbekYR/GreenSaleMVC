using GreenSaleMVC.DTOs;

namespace GreenSaleMVC.BLL.Interfaces
{
    public interface ICategoryService
    {
        ValueTask AddCategory(AddCategoryDto categoryDto);
    }
}
