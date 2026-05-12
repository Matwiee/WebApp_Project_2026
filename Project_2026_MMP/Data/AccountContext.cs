using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_2026_MMP.Data;

public class AccountContext : IdentityDbContext<ApplicationUser>
{
    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(w => w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {


        base.OnModelCreating(builder);

        
        string adminId = "11111111-1111-1111-1111-111111111111";
        string cashierId = "22222222-2222-2222-2222-222222222222";

        var hasher = new PasswordHasher<ApplicationUser>();

        
        var adminUser = new ApplicationUser
        {
            Id = adminId,
            UserName = "admin@flowershop.pl",
            NormalizedUserName = "ADMIN@FLOWERSHOP.PL",
            Email = "admin@flowershop.pl",
            NormalizedEmail = "ADMIN@FLOWERSHOP.PL",
            EmailConfirmed = true,
            SecurityStamp = "STALY_STAMP_ADMIN_123"
        };
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "Qazwsx123,");

        
        var cashierUser = new ApplicationUser
        {
            Id = cashierId,
            UserName = "cashier@flowershop.pl",
            NormalizedUserName = "CASHIER@FLOWERSHOP.PL",
            Email = "cashier@flowershop.pl",
            NormalizedEmail = "CASHIER@FLOWERSHOP.PL",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };
        cashierUser.PasswordHash = hasher.HashPassword(cashierUser, "Qazwsx123,");

       
        builder.Entity<ApplicationUser>().HasData(adminUser, cashierUser);

        
        builder.Entity<IdentityUserClaim<string>>().HasData(
            new IdentityUserClaim<string>
            {
                Id = 100,
                UserId = adminId,
                ClaimType = "Position",
                ClaimValue = "Admin"
            },
            new IdentityUserClaim<string>
            {
                Id = 101,
                UserId = cashierId,
                ClaimType = "Position",
                ClaimValue = "Cashier"
            }
        );
    }
}