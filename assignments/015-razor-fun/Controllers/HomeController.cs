using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _015_razor_fun.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }
  }
}