using Microsoft.AspNetCore.Mvc;

namespace GreenSaleMVC.Areas.User.Controllers
{
    [Area("user")]
    public class BuyerController : Controller
    {
        public IActionResult BuyerCreated()
        {
            return View();
        }
        public IActionResult BuyerPostView()
        {
            return View();
        }
    }
}
