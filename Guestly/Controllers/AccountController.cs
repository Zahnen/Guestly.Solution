using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using Guestly.Models;
using Guestly.ViewModels;

namespace Guestly.Controllers
{
  public class AccountController : Controller
  {
    private readonly GuestlyContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, GuestlyContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      if(ModelState.IsValid)
        {
        var user = new ApplicationUser
        {
          UserName = model.Email,
          Email = model.Email,
          FirstName = model.FirstName,
          LastName = model.LastName
        };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
          await _signInManager.SignInAsync(user, isPersistent: false);
          return RedirectToAction("Login");
        }
        foreach(var error in result.Errors)
        {
          ModelState.AddModelError(string.Empty, error.Description);
        }
      }
    return View(model);
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      if (ModelState.IsValid)
      {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        if(result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        ModelState.AddModelError(string.Empty, "Login failed: Invalid username of password");
      }
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}