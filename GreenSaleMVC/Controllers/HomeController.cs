using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.DTOs;
using GreenSaleMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenSaleMVC.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryInterface _repo;

        public HomeController(ICategoryInterface categoryInterface)
        {
            _repo = categoryInterface;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryCreate()
        {
            return View();
        }
        public IActionResult AddCategory(AddCategoryDto category)
        {
            Category category1 = new Category();
            category1.Name = category.Name;
            category1.Description = category.Description;
            category1.CreatedAt = DateTime.Now;
            category1.UpdatedAt = DateTime.Now;

            _repo.Create(category1);
            return RedirectToAction("index");
        }
    }
}
