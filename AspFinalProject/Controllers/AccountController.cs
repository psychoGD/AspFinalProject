using AspFinalProject.Models;
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
        public IActionResult Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return View(viewModel);
            }
            return View();
        }
    }
}
