﻿using Microsoft.AspNetCore.Mvc;

namespace HealthTracker.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
