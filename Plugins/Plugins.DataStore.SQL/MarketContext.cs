using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions<MarketContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Cut Flowers", Description = "Fresh cut flowers for any occasion" },
                new Category { CategoryId = 2, Name = "Potted Plants", Description = "Beautiful indoor and outdoor potted plants" },
                new Category { CategoryId = 3, Name = "Bouquets", Description = "Pre-arranged floral bouquets crafted by our florists" },
                new Category { CategoryId = 4, Name = "Accessories", Description = "Pots, fertilizers, and gardening tools" }
            );

            // Seeding Products
            modelBuilder.Entity<Product>().HasData(
                // Products for Category 1: Cut Flowers
                new Product { ProductId = 1, CategoryId = 1, Name = "Red Rose", Quantity = 150, Price = 2.99 },
                new Product { ProductId = 2, CategoryId = 1, Name = "White Tulip", Quantity = 200, Price = 1.50 },
                new Product { ProductId = 3, CategoryId = 1, Name = "Sunflower", Quantity = 80, Price = 3.50 },

                // Products for Category 2: Potted Plants
                new Product { ProductId = 4, CategoryId = 2, Name = "Elegant Orchid", Quantity = 40, Price = 24.99 },
                new Product { ProductId = 5, CategoryId = 2, Name = "Monstera Deliciosa", Quantity = 30, Price = 35.00 },
                new Product { ProductId = 6, CategoryId = 2, Name = "Snake Plant", Quantity = 50, Price = 18.50 },

                // Products for Category 3: Bouquets
                new Product { ProductId = 7, CategoryId = 3, Name = "Birthday Joy Bouquet", Quantity = 20, Price = 45.00 },
                new Product { ProductId = 8, CategoryId = 3, Name = "Premium Wedding Roses", Quantity = 10, Price = 89.99 },

                // Products for Category 4: Accessories
                new Product { ProductId = 9, CategoryId = 4, Name = "Ceramic Pot (Medium)", Quantity = 100, Price = 12.99 },
                new Product { ProductId = 10, CategoryId = 4, Name = "Liquid Flower Fertilizer", Quantity = 80, Price = 5.99 }
            );
        }
    }
}
