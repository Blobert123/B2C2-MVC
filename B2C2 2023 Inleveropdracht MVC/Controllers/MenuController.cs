using B2C2_2023_Inleveropdracht_MVC.Data;
using B2C2_2023_Inleveropdracht_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace B2C2_2023_Inleveropdracht_MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly WebsiteDBContext _db;

        public MenuController(WebsiteDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productLijst = _db.Products;
            return View(productLijst);
        }

        // Product aanmaken
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product prod)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(prod);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prod);
        }

        // Product wijzigen
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product prod)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(prod);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prod);
        }

        // Product verwijderen
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProduct(int? id)
        {
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
