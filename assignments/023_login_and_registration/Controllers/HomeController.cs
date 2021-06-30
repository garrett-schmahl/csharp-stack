using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _023_login_and_registration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace _023_login_and_registration.Controllers
{
  public class HomeController : Controller
  {
    private LogAndRegContext db;
    public HomeController(LogAndRegContext context)
    {
      db = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }


    [HttpPost("/RegisterUser")]
    public IActionResult RegisterUser(User user)
    {
      if (!ModelState.IsValid)
      {
        return View("Index");
      }
      if (db.Users.Any(u => u.Email == user.Email))
      {
        ModelState.AddModelError("Email", "Email already in use!");
        return View("Index");
      }

      PasswordHasher<User> Hasher = new PasswordHasher<User>();
      user.Password = Hasher.HashPassword(user, user.Password);

      db.Add(user);
      db.SaveChanges();
      HttpContext.Session.SetInt32("uid", user.UserId);
      return RedirectToAction("Landing");
    }

    [HttpGet("/Landing")]
    public IActionResult Landing()
    {
      int? uid = HttpContext.Session.GetInt32("uid");
      if (uid == null)
      {
        return View();
      }
      return View("Landing");
    }


    [HttpGet("/Logout")]
    public IActionResult LogOut()
    {
      HttpContext.Session.Remove("uid");
      return RedirectToAction("Index");
    }

    [HttpGet("/Home/Landing")]
    public IActionResult ProperLanding()
    {
      return View("Landing");
    }












    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }


    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
  }
}
