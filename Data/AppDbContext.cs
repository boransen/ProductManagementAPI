using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Elektronik" },
            new Category { Id = 2, Name = "Giyim" },
            new Category { Id = 3, Name = "Ev & Yaşam" },
            new Category { Id = 4, Name = "Kitaplar" },
            new Category { Id = 5, Name = "Spor" },
            new Category { Id = 6, Name = "Kozmetik" },
            new Category { Id = 7, Name = "Otomotiv" },
            new Category { Id = 8, Name = "Oyuncak" },
            new Category { Id = 9, Name = "Bahçe" },
            new Category { Id = 10, Name = "Ofis" }
        );
    }
}
