using Microsoft.AspNetCore.Mvc;
namespace _014_portfolio1
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public string Index()
    {
      return "This is my index!";
    }
    [HttpGet("projects")]
    public string projects()
    {
      return "These are my projects";
    }
    [HttpGet("users/contact")]
    public string contact()
    {
      return "This is my Contact!";
    }
  }
}