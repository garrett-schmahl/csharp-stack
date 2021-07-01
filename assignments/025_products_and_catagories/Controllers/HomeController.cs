using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _025_products_and_catagories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _025_products_and_catagories.Controllers
{
  public class HomeController : Controller
  {
    private PacContext db;
    public HomeController(PacContext context)
    {
      db = context;
    }

    [HttpGet("")]
    public IActionResult Index(int categoryID = 1)
    {
      //goal: get a list of products that are not associated with the category

      ViewBag.Products = db.Products
      .Include(p => p.Associations)
      .ThenInclude(pa => pa.Category)
      .Where(p => p.Associations.All(a => a.CategoryID != categoryID))
      .ToList();

      ViewBag.Category = db.Categories
     .Include(c => c.Associations)
     .ThenInclude(ca => ca.Product)
     .FirstOrDefault(c => c.CategoryID == categoryID);
      return View("Index");
    }

    [HttpPost("/AddAssociation")]
    public IActionResult AddAssociation(submitProduct submit)
    {
      Association newAssoc = new Association()
      {
        CategoryID = submit.CategoryID,
        ProductID = submit.ProductID
      };
      db.Associations.Add(newAssoc);
      db.SaveChanges();

      return RedirectToAction("Index");
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
