using Microsoft.AspNetCore.Mvc;

namespace GreenSaleMVC.Areas.Admin.Controllers;

[Area("admin")]
public class AuthController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
