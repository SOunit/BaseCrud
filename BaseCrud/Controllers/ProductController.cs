using BaseCrud.Data;
using BaseCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaseCrud.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _db.Products;
            return View(products);
        }
    }
}
