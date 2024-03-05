using GreenSaleMVC.BLL.Interfaces.Messages;
using GreenSaleMVC.BLL.Services.Bot;
using GreenSaleMVC.DTOs.Messages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.RateLimiting;
using System.Xml.Linq;

namespace GreenSaleMVC.Controllers.Home
{
    public class HomeController : Controller
    {
        public BotService _botService;
        public IMessageService _messageService;
        public HomeController(BotService botService, IMessageService messageService)
        {
            _botService = botService;
            _messageService = messageService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Properties()
        {
            using CancellationTokenSource cts = new();
            await _botService.SendMessage("Salom salom", cts.Token);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(AddMessageDto message)
        {
            if(string.IsNullOrEmpty(message.Letter))
            {
                var info = await _messageService.Add(message);
                if (info.Item2)
                {
                    return RedirectToAction("Index");
                }

                return View();
            }
            return View();
        }
    }
}
