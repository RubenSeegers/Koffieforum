﻿using Microsoft.AspNetCore.Mvc;

namespace Showcase_Contactpagina.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
