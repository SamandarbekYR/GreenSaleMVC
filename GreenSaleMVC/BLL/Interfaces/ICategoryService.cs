using GreenSaleMVC.DTOs;

namespace GreenSaleMVC.BLL.Interfaces;

public interface ICategoryService
{
    ValueTask<(string,bool)> Create(AddCategoryDto categoryDto);
}
