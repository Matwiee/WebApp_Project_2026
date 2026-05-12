using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.CategoriesUseCases.DataStorePluginInterfaces;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product { ProductId = 1, CategoryId = 1, Name = "Red Rose", Quantity = 150, Price = 2.99 },
            new Product { ProductId = 2, CategoryId = 1, Name = "White Tulip", Quantity = 200, Price = 1.50 },
            new Product { ProductId = 3, CategoryId = 1, Name = "Sunflower", Quantity = 80, Price = 3.50 },
            new Product { ProductId = 4, CategoryId = 2, Name = "Elegant Orchid", Quantity = 40, Price = 24.99 },
            new Product { ProductId = 5, CategoryId = 2, Name = "Monstera Deliciosa", Quantity = 30, Price = 35.00 },
            new Product { ProductId = 6, CategoryId = 2, Name = "Snake Plant", Quantity = 50, Price = 18.50 },
            new Product { ProductId = 7, CategoryId = 3, Name = "Birthday Joy Bouquet", Quantity = 20, Price = 45.00 },
            new Product { ProductId = 8, CategoryId = 3, Name = "Premium Wedding Roses", Quantity = 10, Price = 89.99 },
            new Product { ProductId = 9, CategoryId = 4, Name = "Ceramic Pot (Medium)", Quantity = 100, Price = 12.99 },
            new Product { ProductId = 10, CategoryId = 4, Name = "Liquid Flower Fertilizer", Quantity = 80, Price = 5.99 }
        };

        private readonly ICategoryRepository categoryRepository;

        public ProductsInMemoryRepository(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void AddProduct(Product product)
        {
            if (_products != null && _products.Count > 0)
            {
                var maxId = _products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            if (_products == null) _products = new List<Product>();
            _products.Add(product);
        }

        public IEnumerable<Product> GetProducts(bool loadCategory = false)
        {
            if (!loadCategory)
            {
                return _products;
            }
            else
            {
                if (_products != null && _products.Count > 0)
                {
                    _products.ForEach(x =>
                    {
                        if (x.CategoryId.HasValue)
                            x.Category = categoryRepository.GetCategoryById(x.CategoryId.Value);
                    });
                }

                return _products ?? new List<Product>();
            }
        }

        public Product? GetProductById(int productId, bool loadCategory = false)
        {
            var product = _products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null)
            {
                var prod = new Product
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    CategoryId = product.CategoryId
                };

                if (loadCategory && prod.CategoryId.HasValue)
                {
                    prod.Category = categoryRepository.GetCategoryById(prod.CategoryId.Value);
                }

                return prod;
            }

            return null;
        }

        public void UpdateProduct(int productId, Product product)
        {
            if (productId != product.ProductId) return;

            var productToUpdate = _products.FirstOrDefault(x => x.ProductId == productId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.Price = product.Price;
                productToUpdate.CategoryId = product.CategoryId;
            }
        }

        public void DeleteProduct(int productId)
        {
            var product = _products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            var products = _products.Where(x => x.CategoryId == categoryId);
            if (products != null)
                return products.ToList();
            else
                return new List<Product>();
        }
    }
}