using GreenSaleMVC.BLL.Interfaces;
using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.DTOs;
using GreenSaleMVC.Models;

namespace GreenSaleMVC.BLL.Services
{
    public class AddCategoryRepository : ICategoryService
    {
        private readonly IFileService fileService;
        private readonly ICategoryInterface categoryInterface;

        public AddCategoryRepository(IFileService fileService,ICategoryInterface categoryInterface)
        {
            this.fileService = fileService;
            this.categoryInterface = categoryInterface;
        }

        public async ValueTask AddCategory(AddCategoryDto categoryDto)
        {
            string imgUrl = await fileService.UploadImage(categoryDto.Image);
            Category category = new()
            {
                Description = categoryDto.Description,
                Name    = categoryDto.Name,
                ImagePath = imgUrl
            };
            categoryInterface.Create(category);


        }

        
    }
}
