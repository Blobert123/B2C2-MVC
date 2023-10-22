using B2C2_2023_Inleveropdracht_MVC.Data;
using B2C2_2023_Inleveropdracht_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace B2C2_2023_Inleveropdracht_MVC.Controllers
{
    public class HistorieController : Controller
    {
        private readonly WebsiteDBContext _db;

        public HistorieController(WebsiteDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Bestelling> bestellingLijst = _db.Bestellings;
            return View(bestellingLijst);
        }
    }
}
