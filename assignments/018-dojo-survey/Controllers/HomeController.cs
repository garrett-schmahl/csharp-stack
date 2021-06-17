using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _018_dojo_survey.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }

    [HttpPost("result")]
    public ViewResult Result(string name_entry, string location_select, string language_select, string comment_entry)
    {
      ViewBag.name_entry = name_entry;
      ViewBag.location_select = location_select;
      ViewBag.language_select = language_select;
      ViewBag.comment_entry = comment_entry;
      return View("Result");
    }
  }
}