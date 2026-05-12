using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_2026_MMP.Data;

public class AccountContext(DbContextOptions<AccountContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        string newAdminId = "22222222-ffff-ffff-ffff-ffffffffffff";
        string roleId = "11111111-ffff-ffff-ffff-ffffffffffff";

        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = roleId,
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = "SZTYWNY_STAMP_ROLI_123" 
        });

        builder.Entity<ApplicationUser>().HasData(new ApplicationUser
        {
            Id = newAdminId,
            UserName = "szef@flowershop.pl",
            NormalizedUserName = "SZEF@FLOWERSHOP.PL",
            Email = "szef@flowershop.pl",
            NormalizedEmail = "SZEF@FLOWERSHOP.PL",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAIAAYagAAAAEKKPdmOXA0Zpx5iE7fjtSl9hEedtzwcXWStqJFUV5WCTbXtaBe3EloTWYheYA/CBDa==",
            SecurityStamp = "TAJNY_STAMP_NOWEGO_SZEFA_123",
            ConcurrencyStamp = "SZTYWNY_STAMP_SZEFA_123"
        });

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = newAdminId
        });


        builder.Entity<IdentityUserClaim<string>>().HasData(new IdentityUserClaim<string>
        {
            Id = 2,
            UserId = newAdminId,
            ClaimType = "position",
            ClaimValue = "Admin"
        });
    }
}