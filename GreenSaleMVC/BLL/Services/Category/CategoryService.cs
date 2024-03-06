using GreenSaleMVC.BLL.Interfaces;
using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.DTOs;
using Entity = GreenSaleMVC.Data.Entities.Categories;

namespace GreenSaleMVC.BLL.Services.Category;

public sealed class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _dbSet;
    private readonly IFileService _fileService;

    public CategoryService(IUnitOfWork unitOfWork, IFileService fileService)
    {
        _dbSet = unitOfWork;
        _fileService = fileService;
    }
    public async ValueTask<(string, bool)> Create(AddCategoryDto categoryDto)
    {
      
    }
}