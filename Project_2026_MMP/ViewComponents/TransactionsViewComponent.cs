using Microsoft.AspNetCore.Mvc;

namespace Project_2026_MMP.ViewComponents
{
    [ViewComponent]
    public class TransactionsViewComponent : ViewComponent
    {
        public string Invoke()
        {


            return "List of Transactions";
        }
    }
}
