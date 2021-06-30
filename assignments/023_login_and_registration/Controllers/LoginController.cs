using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _023_login_and_registration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace _023_login_and_registration.Controllers
{
  public class LoginController : Controller
  {

    private LogAndRegContext db;
    public LoginController(LogAndRegContext context)
    {
      db = context;
    }
    [HttpGet("/login")]
    public IActionResult Login()
    {
      return View("Login");
    }

    [HttpPost("/loginUser")]
    public IActionResult LoginUser(LoginUser userSubmission)
    {
      var userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
      if (ModelState.IsValid)
      {
        if (userInDb == null)
        {
          ModelState.AddModelError("Email", "Invalid Email/Password");
          return View("Login");
        }

        var hasher = new PasswordHasher<LoginUser>();
        var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);

        if (result == 0)
        {
          ModelState.AddModelError("Email", "Invalid Email/Password");
          return View("Login");
        }
      }
      HttpContext.Session.SetInt32("uid", userInDb.UserId);
      return RedirectToAction("landing", "");
    }
  }
}