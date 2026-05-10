
using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.InMemory;
using Plugins.DataStore.SQL;
using UseCases;
using UseCases.CategoriesUseCases;
using UseCases.CategoriesUseCases.DataStorePluginInterfaces;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductsUseCases;
using Microsoft.AspNetCore.Identity;
using Project_2026_MMP.Data;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsEnvironment("QA"))
{
    builder.WebHost.UseStaticWebAssets();
}

builder.Services.AddDbContext<AccountContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MarketManagment"));
});

builder.Services.AddDbContext<MarketContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MarketManagment"));
});

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AccountContext>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Inventory", p => p.RequireClaim("Position", "Inventory"));
    options.AddPolicy("Cashiers", p => p.RequireClaim("Position", "Cashier"));

});

if (builder.Environment.IsEnvironment("QA"))
{
    builder.Services.AddSingleton<ICategoryRepository, CategoriesInMemoryRepository>();
    builder.Services.AddSingleton<IProductRepository, ProductsInMemoryRepository>();
    builder.Services.AddSingleton<ITransactionRepository, TransactionsInMemoryRepository>();
}
else
{
    builder.Services.AddTransient<ICategoryRepository, CategorySQLRepository>();
    builder.Services.AddTransient<IProductRepository, ProductSQLRepository>();
    builder.Services.AddTransient<ITransactionRepository, TransactionSQLRepository>();
}

builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddTransient<IViewSelectedCategoryUseCase, ViewSelectedCategoryUseCase>();
builder.Services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

builder.Services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();
builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();
builder.Services.AddTransient<IEditProductUseCase, EditProductUseCase>();
builder.Services.AddTransient<IViewProductsInCategoryUseCase, ViewProductsInCategoryUseCase>();
builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddTransient<IViewSelectedProductUseCase, ViewSelectedProductUseCase>();
builder.Services.AddTransient<ISellProductUseCase, SellProductUseCase>();

builder.Services.AddTransient<IRecordTransactionUseCase, RecordTransactionUseCase>();
builder.Services.AddTransient<IGetTodayTransactionsUseCase, GetTodayTransactionsUseCase>();
builder.Services.AddTransient<ISearchTransactionsUseCase, SearchTransactionsUseCase>();

var app = builder.Build();

app.UseRouting();

app.MapStaticAssets();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
