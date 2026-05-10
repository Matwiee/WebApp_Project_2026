using CoreBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;
using Project_2026_MMP.ViewModels;
using UseCases;
using UseCases.CategoriesUseCases;
using UseCases.ProductsUseCases;

namespace Project_2026_MMP.Controllers
{
    [Authorize(Policy = "Inventory")]
    public class ProductsController : Controller
    {
        private readonly IAddProductUseCase addProductUseCase;
        private readonly IEditProductUseCase editProductUseCase;
        private readonly IDeleteProductUseCase deleteProductUseCase;
        private readonly IViewSelectedProductUseCase viewSelectedProductUseCase;
        private readonly IViewProductsUseCase viewProductsUseCase;
        private readonly IViewCategoriesUseCase viewCategoriesUseCase;

        public ProductsController(
            IAddProductUseCase addProductUseCase,
            IEditProductUseCase editProductUseCase,
            IDeleteProductUseCase deleteProductUseCase,
            IViewSelectedProductUseCase viewSelectedProductUseCase,
            IViewProductsUseCase viewProductsUseCase,
            IViewCategoriesUseCase viewCategoriesUseCase)
        {
            this.addProductUseCase = addProductUseCase;
            this.editProductUseCase = editProductUseCase;
            this.deleteProductUseCase = deleteProductUseCase;
            this.viewSelectedProductUseCase = viewSelectedProductUseCase;
            this.viewProductsUseCase = viewProductsUseCase;
            this.viewCategoriesUseCase = viewCategoriesUseCase;
        }

        public IActionResult Index()
        {
            var products = viewProductsUseCase.Execute(loadCategory: true);
            return View(products);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "add";

            var productViewModel = new ProductViewModel
            {
                Categories = viewCategoriesUseCase.Execute()
            };

            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                addProductUseCase.Execute(productViewModel.Product);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Action = "add";
            productViewModel.Categories = viewCategoriesUseCase.Execute();
            return View(productViewModel);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Action = "edit";

            var productViewModel = new ProductViewModel
            {
                Product = viewSelectedProductUseCase.Execute(id) ?? new Product(),
                Categories = viewCategoriesUseCase.Execute()
            };

            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                editProductUseCase.Execute(productViewModel.Product.ProductId, productViewModel.Product);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Action = "edit";
            productViewModel.Categories = CategoriesRepository.GetCategories();
            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            deleteProductUseCase.Execute(id);
            return RedirectToAction(nameof(Index));
        }

    }
}