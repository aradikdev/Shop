using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers;

public class ProductsController : Controller
{
    private readonly ShopContext _context;

    public ProductsController(ShopContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        List<Products> products = _context.Products.ToList();
        return View(products);
    }
    public IActionResult Create()
    {
        ViewBag.Brands = _context.Brands.ToList();
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }
    [HttpPost]
    public IActionResult Create(Products product)
    {
        if (ModelState.IsValid)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(product);
    }
}
