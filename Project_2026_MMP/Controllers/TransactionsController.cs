using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.ViewModels;
using Project_2026_MMP.Models;

namespace Project_2026_MMP.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            TransactionsViewModel transactionsViewModel = new TransactionsViewModel();
            return View(transactionsViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(TransactionsViewModel transactionsViewModel)
        {
            var transactions = TransactionsRepository.Search(
                transactionsViewModel.CashierName??string.Empty,
                transactionsViewModel.StartDate,
                transactionsViewModel.EndDate);

            transactionsViewModel.Transactions = transactions;

            return View("Index", transactionsViewModel);
        }
    }
}
