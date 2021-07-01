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
      return RedirectToAction("DisplayCategories", new { categoryID = categoryID });
    }


    [HttpGet("/category/{categoryID}")]
    public IActionResult DisplayCategories(int categoryID)
    {
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

      return RedirectToAction("Index", new { categoryID = submit.CategoryID });
    }



    [HttpGet("/categories")]
    public IActionResult DisplayCategories()
    {
      ViewBag.Categories = db.Categories;
      return View();
    }

    [HttpPost("/AddCategory")]
    public IActionResult AddCategory(Category newCat)
    {
      db.Categories.Add(newCat);
      db.SaveChanges();
      return RedirectToAction("DisplayCategories");
    }

    [HttpGet("/products")]
    public IActionResult DisplayProducts()
    {
      ViewBag.Products = db.Products;
      return View();
    }

    [HttpPost("/AddProduct")]
    public IActionResult AddProduct(Product newProd)
    {
      db.Products.Add(newProd);
      db.SaveChanges();
      return RedirectToAction("DisplayProducts");
    }


    [HttpGet("/product/{productID}")]
    public IActionResult DisplayProduct(int productID)
    {
      ViewBag.Categories = db.Categories
      .Include(p => p.Associations)
      .ThenInclude(pa => pa.Product)
      .Where(p => p.Associations.All(a => a.ProductID != productID))
      .ToList();

      ViewBag.Product = db.Products
     .Include(c => c.Associations)
     .ThenInclude(ca => ca.Category)
     .FirstOrDefault(c => c.ProductID == productID);
      return View("DisplayProduct");
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
