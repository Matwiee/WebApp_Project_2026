using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;
using Project_2026_MMP.ViewModels;

namespace Project_2026_MMP.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var salesViewModel = new SalesViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(salesViewModel);
        }
    }
}
