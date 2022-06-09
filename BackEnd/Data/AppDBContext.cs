using BackEnd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class AppDBContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            this._options = options;
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<IdentityUserRole<string>>().HasKey(ub => new { ub.UserId, ub.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(ub => ub.UserId);
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(ub => ub.UserId);*/
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(ub => new { ub.UserId, ub.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(ub => ub.UserId);
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(ub => ub.UserId);
            modelBuilder.Entity<IdentityUserClaim<string>>();
            modelBuilder.Entity<IdentityRoleClaim<string>>();

           

         
            modelBuilder.Entity<Category>()
            .HasMany(s => s.Products)
            .WithOne(c => c.Category)
            .HasForeignKey(c => c.CategoryId);
            modelBuilder.Entity<Product>()
            .HasMany(s => s.Orders)
            .WithOne(c => c.Product)
            .HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<ApplicationUser>()
            .HasMany(s => s.Orders)
            .WithOne(c => c.ApplicationUser)
            .HasForeignKey(c => c.ApplicationUserId);

        }
    }
}
