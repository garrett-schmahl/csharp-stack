using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _021_Random_Password_Generator.Models;
using Microsoft.AspNetCore.Http;


namespace _021_Random_Password_Generator.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("")]
    public IActionResult Index()
    {
      if (HttpContext.Session.GetInt32("RefreshCount") == null)
      {
        HttpContext.Session.SetInt32("RefreshCount", 0);
      }
      HttpContext.Session.SetInt32("RefreshCount", (int)HttpContext.Session.GetInt32("RefreshCount") + 1);
      ViewBag.RefreshCount = (int)HttpContext.Session.GetInt32("RefreshCount");
      Random random = new Random();
      ViewBag.Password = Math.Floor(random.NextDouble() * 100000000000000);
      return View();
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

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }
  }
}
