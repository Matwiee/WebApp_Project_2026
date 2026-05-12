using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;
using UseCases;
using UseCases.CategoriesUseCases;
using UseCases.ProductsUseCases;

[Authorize]
public class HomeController : Controller
{
    private readonly IViewCategoriesUseCase _viewCategoriesUseCase;
    private readonly IViewProductsUseCase _viewProductsUseCase;
    private readonly IViewTransactionsUseCase _viewTransactionsUseCase;

    public HomeController(
        IViewCategoriesUseCase viewCategoriesUseCase,
        IViewProductsUseCase viewProductsUseCase,
        IViewTransactionsUseCase viewTransactionsUseCase)
    {
        _viewCategoriesUseCase = viewCategoriesUseCase;
        _viewProductsUseCase = viewProductsUseCase;
        _viewTransactionsUseCase = viewTransactionsUseCase;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {
        var transactions = _viewTransactionsUseCase.Execute(null, DateTime.Today, DateTime.Now);

        var model = new DashboardViewModel
        {
            DailySales = transactions.Sum(x => x.SoldQty * x.Price),
            InventoryCount = _viewProductsUseCase.Execute().Count(),
            CategoryCount = _viewCategoriesUseCase.Execute().Count(),
            TransactionCount = transactions.Count()
        };

        return View(model);
    }

    public IActionResult Categories() => RedirectToAction("Index", "Categories");
    public IActionResult Products() => RedirectToAction("Index", "Products");
    public IActionResult Sell() => RedirectToAction("Index", "Sales");
    public IActionResult Transactions() => RedirectToAction("Index", "Transactions");
}