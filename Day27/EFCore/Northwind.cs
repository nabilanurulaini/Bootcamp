using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;

namespace EFCore;

public class Northwind : DbContext
{
    //generate dbset untuk category dan product menggunakan generic karena categories dan products adalah nama table
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string conn = $"Data Source={path}";
        optionsBuilder.UseSqlite(conn);
    }
    //ini optional jika menggunakan fluent api
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Category>()
    //         .Property(c => c.CategoryName)
    //         .IsRequired()
    //         .HasMaxLength(15);

    //         if(Database.ProviderName?.Contains("Sqlite") ?? false)
    //         {
    //             modelBuilder.Entity<Product>()
    //                 .Property(p => p.Cost)
    //                 .HasConversion<double>();
    //         }
    // }
}
