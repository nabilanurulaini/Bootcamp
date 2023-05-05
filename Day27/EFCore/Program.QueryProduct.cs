using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
namespace EFCore;

partial class Program
{
    public static void ShowProductWithCategoryAndStock()
    {
        using (Northwind db = new Northwind())
        {
            
            PrintTitle("Show Product With Category And Stock");
            var products = db.Products.Include(p => p.Category).Where(p => p.Stock > 0);
            foreach (var product in products)
            {
                PrintLn($"{product.ProductID}. {product.ProductName} - Category {product.Category.CategoryName} - Stock {product.Stock}");
            }
        }
    }
    //find all product where stock > input
    public static void SearchProductByStock()
    {
        using(Northwind db = new Northwind())
        {
            PrintTitle("Search Product By Stock");
            Print("Input stock = ");
            string inputStock = GetInput();
            //linq for search product where stock > input
            var products = db.Products.Where(p => p.Stock > int.Parse(inputStock));
            foreach (var product in products)
            {
                PrintLn($"{product.ProductID}. {product.ProductName} - Stock {product.Stock}");
            }
            
        }
    }
}
