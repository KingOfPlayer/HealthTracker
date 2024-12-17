using Microsoft.AspNetCore.Mvc;

namespace HealthTracker.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewDevice()
        {
            return View();
        }
        public IActionResult ViewDevices()
        {
            return View();
        }
    }
}
