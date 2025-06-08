using Lab7.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Lab7.Models;

namespace Lab7.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        public IActionResult Edit(int id)
        {
            var product = _context.Product.Find(id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        public IActionResult Delete(int id)
        {
            var product = _context.Product.Find(id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Product.Find(id);
            if (product == null) return NotFound();

            _context.Product.Remove(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
