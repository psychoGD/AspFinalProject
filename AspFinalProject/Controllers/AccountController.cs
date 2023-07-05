using AspFinalProject.Entities;
using AspFinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class AccountController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            //Register Method On Develop
            return View(viewModel);
        }
    }
}
