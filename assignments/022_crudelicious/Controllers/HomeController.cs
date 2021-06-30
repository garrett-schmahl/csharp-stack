using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _022_crudelicious.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace _022_crudelicious.Controllers
{
  public class HomeController : Controller
  {
    private DishContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, DishContext context)
    {
      _logger = logger;
      _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
      List<Dish> AllDishes = _context.Dishes.OrderByDescending(dish => dish.CreatedAt).ToList();
      ViewBag.AllDishes = AllDishes;
      return View();
    }
    [HttpGet("/newDish")]
    public IActionResult NewDish()
    {
      return View("NewDish");
    }

    [HttpPost("/submitDish")]
    public IActionResult SubmitDish(Dish newDish)
    {
      if (ModelState.IsValid)
      {
        _context.Add(newDish);
        _context.SaveChanges();
        return RedirectToAction("");
      }
      else
      {
        return View("NewDish");
      }
    }

    [HttpGet("/{dishVal}")]
    public IActionResult ViewDish(int dishVal)
    {
      Dish dish = _context.Dishes.FirstOrDefault(u => u.DishId == dishVal);
      ViewBag.Dish = dish;
      return View("ViewDish");
    }


    [HttpPost("/delete/{dishVal}")]
    public IActionResult DeleteDish(int dishVal)
    {
      Dish RetrieveDish = _context.Dishes.SingleOrDefault(dish => dish.DishId == dishVal);
      _context.Dishes.Remove(RetrieveDish);
      _context.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("/edit/{dishVal}")]
    public IActionResult EditDish(int dishVal)
    {
      Dish RetrieveDish = _context.Dishes.SingleOrDefault(dish => dish.DishId == dishVal);
      ViewBag.Dish = RetrieveDish;
      return View("EditDish");
    }

    [HttpPost("home/update/{dishVal}")]
    public IActionResult UpdateDish(int dishVal, Dish EditDish)
    {
      Dish RetrieveDish = _context.Dishes.SingleOrDefault(dish => dish.DishId == dishVal);
      ViewBag.Dish = RetrieveDish;

      RetrieveDish.Chef = EditDish.Chef;
      RetrieveDish.Name = EditDish.Name;
      RetrieveDish.Description = EditDish.Description;
      RetrieveDish.Calories = EditDish.Calories;
      RetrieveDish.Tastiness = EditDish.Tastiness;
      RetrieveDish.UpdatedAt = DateTime.Now;

      _context.Dishes.Update(RetrieveDish);
      _context.SaveChanges();

      return RedirectToAction("ViewDish", new { dishVal = dishVal });
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
