using AspFinalProject.Entities;
using AspFinalProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Diagnostics;

namespace AspFinalProject.Controllers
{
	public class HomeController : Controller
    {



		//public override void OnActionExecuting(ActionExecutingContext context)
		//{
		//	if (_httpContextAccessor.HttpContext.User.Identity.Name != null)
		//		ViewDataLoading();
		//	base.OnActionExecuting(context);
		//}

		//[Authorize]
		//private void ViewDataLoading()
		//{

		//	if (_userViewModel == null)
		//	{
		//		var _userName = _httpContextAccessor.HttpContext.User.Identity.Name;
		//		var user = _userManager.Users.Include(u => u.FriendRequests).FirstOrDefaultAsync(u => u.UserName == _userName).Result;

		//		_user = user;

		//		if (user != null)
		//		{
		//			_userViewModel = new UserViewModel(user.Id, user.UserName, user.Email, user.FriendRequests.ToList());
		//			ViewData["User"] = _userViewModel;
		//			// ViewBag.User = _userViewModel;
		//		}
		//		else RedirectToAction("login");
		//	}
		//}

		//[Authorize]
		//public async Task<JsonResult> SendFollow(string id)
		//{
		//	var OwnUser = await _context.Users.Include(f => f.FriendRequests).FirstOrDefaultAsync(u => u.Id == id);
		//	var list = _context.FriendRequests.Where(f => f.ReceiverId == id);
		//	OwnUser.FriendRequests = list.ToList();
		//	if (OwnUser != null)
		//	{
		//		OwnUser.FriendRequests.Add(new FriendRequest($"{_userViewModel.Name} Send friend request at {DateTime.Now.ToShortDateString()}",
		//			"Request", _user.Id, OwnUser, id));

		//		await _userManager.UpdateAsync(OwnUser);

		//		return new JsonResult(OwnUser);
		//	}
		//	else
		//	{
		//		return new JsonResult("Error");
		//	}
		//}

		//[Authorize]
		//public async Task<JsonResult> CancelFollow(string id)
		//{
		//	var OwnUser = await _userManager.Users.Include(a => a.FriendRequests).FirstOrDefaultAsync(u => u.Id == id);

		//	if (OwnUser == null)
		//		return new JsonResult("Null");

		//	var collection = _context.FriendRequests.Where(f => f.SenderId == _user.Id && f.ReceiverId == id);
		//	if (collection.Any())
		//	{
		//		foreach (var item in collection.ToList())
		//		{
		//			_context.FriendRequests.Remove(item);
		//			OwnUser.FriendRequests.Remove(item);
		//		}

		//		await _context.SaveChangesAsync();
		//	}

		//	return new JsonResult("Done");
		//}

		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public async Task<ActionResult> register(RegisterViewModel model)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		CustomIdentityUser user = new CustomIdentityUser
		//		{
		//			UserName = model.Username,
		//			Email = model.Email,


		//		};
		//		IdentityResult result = await _userManager.CreateAsync(user, model.Password);

		//		if (result.Succeeded)
		//		{

		//			if (!_roleManager.RoleExistsAsync("User").Result)
		//			{
		//				CustomIdentityRole role = new CustomIdentityRole
		//				{
		//					Name = "User"
		//				};

		//				IdentityResult roleResult = await _roleManager.CreateAsync(role);
		//				if (!roleResult.Succeeded)
		//				{
		//					ModelState.AddModelError("", "We can not add the role");
		//					return View(model);
		//				}
		//			}

		//			await _userManager.AddToRoleAsync(user, "User");
		//			return RedirectToAction("login", "Home");
		//		}
		//	}
		//	return View(model);
		//}

		//[HttpPost]
		//public async Task<ActionResult> login(LoginViewModel model)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
		//		if (result.Succeeded)
		//		{
		//			return RedirectToAction("index", "Home");
		//		}
		//		ModelState.AddModelError("", "Invalid Login");
		//	}
		//	return View(model);
		//}

		
		public async Task<IActionResult> groups()
		{
			return PartialView("groups");
		}

		
		public IActionResult friends()
		{
			return View();
		}

		
		public IActionResult favorite()
		{
			return View();
		}

		public IActionResult birthday()
		{
			return View();
		}

		public IActionResult events()
		{
			return View();
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		
		[Route("/home/help-and-support")]
		public IActionResult help_and_support()
		{
			return View("help-and-support");
		}

		
		[Route("/home/live-chat")]
		public IActionResult live_chat()
		{
			return View("live-chat");
		}

		public IActionResult marketplace()
		{
			return View();
		}

		public IActionResult messages()
		{
			return View();
		}

		
		[Route("/home/my-profile")]
		public IActionResult my_profile()
		{
			return View("my-profile");
		}

		public IActionResult notifications()
		{
			return View();
		}

		public IActionResult settings()
		{
			return View();
		}

		public IActionResult video()
		{
			return View();
		}

		public IActionResult weather()
		{
			return View();
		}

		[Route("/home/forgot-password")]
		public IActionResult forgot_password()
		{
			return View();
		}

		//Accound
		public IActionResult register() => View();

		public IActionResult login()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}