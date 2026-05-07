using Project_2026_MMP.Models;

namespace Project_2026_MMP.ViewModels
{
    public class SalesViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
