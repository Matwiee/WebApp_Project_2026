using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;
using Project_2026_MMP.ViewModels;

namespace Project_2026_MMP.ViewModels
{
    public class SalesViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
