using Microsoft.AspNetCore.Mvc;

namespace HealthTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
