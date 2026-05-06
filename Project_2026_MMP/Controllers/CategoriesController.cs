using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;

namespace Project_2026_MMP.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue?id.Value : 0  };

            return View(category);

        }

    }
}
