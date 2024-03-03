using GreenSaleMVC.BLL.Interfaces;
using GreenSaleMVC.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GreenSaleMVC.Areas.Admin.Controllers;

[Area("admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
