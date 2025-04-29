using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using System.Runtime.CompilerServices;

namespace Lab3.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product() { id = 1, name = "Product1", price = 10.0 },
            new Product() { id = 2, name = "Product2", price = 20.0 },
            new Product() { id = 3, name = "Product3", price = 30.0 },
            new Product() { id = 4, name = "Product4", price = 40.0 },
            new Product() { id = 5, name = "Product5", price = 50.0 },
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
          
            return View(products);
        }


        // them san pha m
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                products.Add(newProduct);

                return RedirectToAction("Details");
            }
            return View(newProduct);
        }

        

    }

}

