using GreenSaleMVC.BLL.Interfaces;
using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.DTOs;
using GreenSaleMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenSaleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ICategoryService CategoryInterface { get; }

        public HomeController(ICategoryService categoryInterface)
        {
            
            CategoryInterface = categoryInterface;
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

            CategoryInterface.AddCategory(category);
            return RedirectToAction("Index");



        }
    }
}
