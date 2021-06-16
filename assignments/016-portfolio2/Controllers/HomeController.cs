using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _016_portfolio2.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }
    [HttpGet("/projects")]
    public ViewResult Projects()
    {
      return View("Projects");
    }

    [HttpGet("/contact")]
    public ViewResult Contact()
    {
      return View("Contact");
    }



    // [HttpGet("")]
    // public ViewResult Index(string food = "bananas")
    // {
    //   ViewBag.food = food;
    //   return View(); //defaults to Index
    // }
    // [HttpGet("/redirect")]
    // public RedirectToActionResult Method()
    // {
    //   return RedirectToAction("Index", new { food = "apples" });

    // }
  }
}