using CoreBusiness;
using UseCases.CategoriesUseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoriesInMemoryRepository : ICategoryRepository
    {
        private List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Cut Flowers", Description = "Fresh cut flowers for any occasion" },
            new Category { CategoryId = 2, Name = "Potted Plants", Description = "Beautiful indoor and outdoor potted plants" },
            new Category { CategoryId = 3, Name = "Bouquets", Description = "Pre-arranged floral bouquets crafted by our florists" },
            new Category { CategoryId = 4, Name = "Accessories", Description = "Pots, fertilizers, and gardening tools" }
        };

        public  void AddCategory(Category category)
        {
            if (_categories != null && _categories.Count > 0)
            {
                var maxId = _categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            if (_categories == null) _categories = new List<Category>();
            _categories.Add(category);
        }

        public  IEnumerable<Category> GetCategories() => _categories;

        public  Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description,
                };
            }

            return null;
        }

        public  void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;

            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public  void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }

    }
}
