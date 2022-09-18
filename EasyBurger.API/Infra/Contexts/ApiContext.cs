using EasyBurger.API.Infra.Configuration;
using EasyBurger.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBurger.API.Infra.Contexts
{
    public class ApiContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<User> Users { get; set; } = default!;

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
