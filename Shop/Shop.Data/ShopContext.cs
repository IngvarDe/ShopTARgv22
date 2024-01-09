using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;


namespace Shop.Data
{
    public class ShopContext : IdentityDbContext<ApplicationUser>
    {
        public ShopContext
            (
                DbContextOptions<ShopContext> options
            ) : base(options) { }

        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToApi> FileToApis { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileToDatabase> FileToDatabases { get; set; }
    }
}
