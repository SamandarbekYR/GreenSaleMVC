using Microsoft.AspNetCore.Mvc;

namespace GreenSaleMVC.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Properties()
        {
            return View();
        }
    }
}
