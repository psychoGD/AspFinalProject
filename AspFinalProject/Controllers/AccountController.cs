﻿using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
