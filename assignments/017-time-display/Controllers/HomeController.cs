using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _017_time_display.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      DateTime CurrentTime = DateTime.Now;
      ViewBag.CurrentTime = CurrentTime;
      return View();
    }
  }
}