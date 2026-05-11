using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.ViewModels;
using UseCases;
using UseCases.CategoriesUseCases;
using UseCases.ProductsUseCases;
using Project_2026_MMP.Models;

namespace Project_2026_MMP.Controllers
{
    [Authorize(Policy = "Cashiers")]
    public class SalesController : Controller
    {
        private readonly IViewCategoriesUseCase viewCategoriesUseCase;
        private readonly IViewSelectedProductUseCase viewSelectedProductUseCase;
        private readonly ISellProductUseCase sellProductUseCase;
        private readonly IViewProductsInCategoryUseCase viewProductsInCategoryUseCase;

        public SalesController(IViewCategoriesUseCase viewCategoriesUseCase,
            IViewSelectedProductUseCase viewSelectedProductUseCase,
            ISellProductUseCase sellProductUseCase,
            IViewProductsInCategoryUseCase viewProductsInCategoryUseCase)
        {
            this.viewCategoriesUseCase = viewCategoriesUseCase;
            this.viewSelectedProductUseCase = viewSelectedProductUseCase;
            this.sellProductUseCase = sellProductUseCase;
            this.viewProductsInCategoryUseCase = viewProductsInCategoryUseCase;
        }

        public IActionResult Index()
        {
            var salesViewModel = new SalesViewModel
            {
                // Use the correct variable name from your constructor
                Categories = viewCategoriesUseCase.Execute()
            };

            // This loads your Index.cshtml (the code you just shared)
            return View(salesViewModel);
        }

        public IActionResult SellProductPartial(int productId)
        {
            var product = viewSelectedProductUseCase.Execute(productId);

            // This loads ONLY the name and price into #productDetailPartial
            return PartialView("_SellProduct", product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Sell(SalesViewModel salesViewModel)
        {
            if (ModelState.IsValid)
            {
                var currentUserName = User.Identity?.Name ?? "Unknown";

                sellProductUseCase.Execute(
                    currentUserName,
                    salesViewModel.SelectedProductId,
                    salesViewModel.QuantityToSell);

                return Ok(new { message = "Transaction complete! Inventory updated." });
            }

            var errorMessage = ModelState.Values
                                         .SelectMany(v => v.Errors)
                                         .FirstOrDefault()?.ErrorMessage;

            return BadRequest(errorMessage);
        }

        public IActionResult ProductsByCategoryPartial(int categoryId)
        {
            var products = viewProductsInCategoryUseCase.Execute(categoryId);
            return PartialView("_Products", products);
        }

        public IActionResult GetTransactionsPartial(string cashierName)
        {
            return ViewComponent("Transactions", new { cashierName = cashierName });
        }
    }
}