using B2C2_2023_Inleveropdracht_MVC.Data;
using B2C2_2023_Inleveropdracht_MVC.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
