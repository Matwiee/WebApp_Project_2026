using Microsoft.AspNetCore.Mvc;

namespace Project_2026_MMP.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var salesViewModel = new ViewModels.SalesViewModel
            {
                Categories = Models.CategoriesRepository.GetCategories()
            };
            return View(salesViewModel);
        }
    }
}
