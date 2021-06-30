using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _024_chef_and_dishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace _024_chef_and_dishes.Controllers
{
  public class HomeController : Controller
  {

    private CadContext db;
    public HomeController(CadContext context)
    {
      db = context;
    }


    [HttpGet("")]
    public IActionResult Index()
    {
      List<Chef> allChefs = db.Chefs
      .Include(chef => chef.Dishes)
      .ToList();
      return View("Index", allChefs);
    }

    [HttpGet("/allDishes")]
    public IActionResult AllDishes()
    {
      List<Dish> allDishes = db.Dishes
      .Include(dish => dish.Chef)
      .ToList();
      return View("AllDishes", allDishes);
    }

    [HttpGet("/AddChef")]
    public IActionResult AddChef()
    {
      return View("AddChef");
    }

    [HttpGet("/AddDish")]
    public IActionResult AddDish()
    {
      List<Chef> allChefs = db.Chefs.Include(chef => chef.Dishes).ToList();
      ViewBag.allChefs = allChefs;
      return View("AddDish");
    }


    [HttpPost("/CreateChef")]
    public IActionResult CreateChef(Chef newChef)
    {
      if (!ModelState.IsValid)
      {
        return View("Index");
      }
      if (db.Chefs.Any(u => u.FirstName == newChef.FirstName && u.LastName == newChef.LastName))
      {
        ModelState.AddModelError("FirstName", "Chef already exists!");
        return View("Index");
      }

      db.Add(newChef);
      db.SaveChanges();
      return RedirectToAction("");
    }
    [HttpPost("/CreateDish")]
    public IActionResult CreateDish(Dish newDish)
    {
      if (!ModelState.IsValid)
      {
        return View("AddDish");
      }
      db.Add(newDish);
      db.SaveChanges();
      return RedirectToAction("AllDishes");
    }


















    public IActionResult Privacy()
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
