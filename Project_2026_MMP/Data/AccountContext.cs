using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AccountContext(DbContextOptions<AccountContext> options) : IdentityDbContext<Project_2026_MMP.Data.ApplicationUser>(options)
{
}
