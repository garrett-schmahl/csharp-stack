using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _019_viewmodel_fun.Models;

namespace _019_viewmodel_fun.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      Message WelcomeMessage = new Message()
      {
        Content = "SHOOO BOP DEE DOOOOOOOOOOOOO"
      };
      return View(WelcomeMessage);
    }

    public IActionResult Numbers()
    {
      Numbers PassNums = new Numbers()
      {
        NumArray = new int[] { 1, 2, 3, 4, 5, 6 }
      };
      return View("Numbers", PassNums);
    }

    public IActionResult User()
    {
      Person PersonOne = new Person()
      {
        FirstName = "Johnny",
        LastName = "Appleseed"
      };
      return View("User", PersonOne);
    }
    public IActionResult Users()
    {
      Person PersonOne = new Person()
      {
        FirstName = "Johnny",
        LastName = "Appleseed"
      };
      Person PersonTwo = new Person()
      {
        FirstName = "Deetz",
        LastName = "Nuts"
      };
      Person PersonThree = new Person()
      {
        FirstName = "Maddix",
        LastName = "Iniomoth"
      };
      List<Person> viewModel = new List<Person>()
      {
        PersonOne, PersonTwo, PersonThree
      };

      return View("Users", viewModel);
    }



    public ViewResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public ViewResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
