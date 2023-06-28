using AspFinalProject.Entities;
using AspFinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(UserManager<CustomIdentityUser> userManager,
            RoleManager<CustomIdentityRole> roleManager,
            SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

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
            if (ModelState.IsValid)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    UserName = viewModel.Name,
                    Email = viewModel.Email
                };
                IdentityResult result = _userManager.CreateAsync(user, viewModel.Password).Result;

                //if(result.Succeeded)
                //{
                if (!_roleManager.RoleExistsAsync("User").Result)
                {
                    CustomIdentityRole role = new CustomIdentityRole
                    {
                        Name = "User"
                    };

                    IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot Added Role");
                        return View(viewModel);
                    }

                }
                _userManager.AddToRoleAsync(user, "User").Wait();
                return RedirectToAction("Login", "Account");
                //}



            }
            return View();
        }
    }
}
