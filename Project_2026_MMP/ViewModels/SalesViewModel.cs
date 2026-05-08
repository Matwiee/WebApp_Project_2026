using Microsoft.AspNetCore.Mvc;
using Project_2026_MMP.Models;
using Project_2026_MMP.ViewModels.Validations;      
using System.ComponentModel.DataAnnotations;



namespace Project_2026_MMP.ViewModels
{
    public class SalesViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        public int SelectedProductId { get; set; }

        [Display(Name = "Quantity")]
        [Range(1, int.MaxValue)]
        [SalesViewModel_EnsureProperQuantity]
        public int QuantityToSell { get; set; }
    }
}
