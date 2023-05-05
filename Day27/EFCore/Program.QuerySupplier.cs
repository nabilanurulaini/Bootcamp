using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
namespace EFCore;

partial class Program
{
    public static void ShowSupplierWithProduct()
    {
        using(Northwind db = new Northwind())
        {
            PrintTitle("Show Supplier With Product");
            var suppliers = db.Suppliers.Include(s => s.Products);
            foreach (var supplier in suppliers)
            {
                PrintLn($"{supplier.SupplierId}. {supplier.CompanyName}");
                foreach (var product in supplier.Products)
                {
                    PrintLn($"- {product.ProductName}");
                }
            }
        }

    }
    
}
