using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;

namespace Project_2026_MMP.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts(loadCategory: true);
            return View(products);
        }
    }
}
