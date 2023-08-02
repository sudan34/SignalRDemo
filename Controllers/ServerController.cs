using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Hubs;
using SignalRDemo.Models;

namespace SignalRDemo.Controllers
{
    public class ServerController : Controller
    {
        private readonly IHubContext<NotificationHub> _notificationHub;

        public ServerController(IHubContext<NotificationHub> notificationHub)
        {
            _notificationHub = notificationHub;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.NumberOfClient = ConnectedUser.UserId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Notification model)
        {
            await _notificationHub.Clients.All.SendAsync("ReceiceMsg", model.Message);
            return View();
        }
    }
}
