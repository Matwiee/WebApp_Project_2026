using Project_2026_MMP.Models;

namespace Project_2026_MMP.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public Product Product { get; set; } = new Product();

    }
}
