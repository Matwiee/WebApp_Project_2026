using Project_2026_MMP.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_2026_MMP.ViewModels
{
    public class TransactionsViewModel
    {
        [Display(Name = "Cashier Name")]
        public string? CashierName { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; } = DateTime.Today;
        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
