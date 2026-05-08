using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;

namespace Project_2026_MMP.ViewComponents
{
    [ViewComponent]
    public class TransactionsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string userName)
        {
            var transactions = TransactionsRepository.GetByDayAndCashier(userName, DateTime.Now);

            return View(transactions);
        }
    }
}
