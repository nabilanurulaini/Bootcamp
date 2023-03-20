using System;
namespace OOP2{
    class OnlineShop{
        static void Main()
        {
            Product p1 = new Product("Laptop", "Dell Inspiron 15", 500);
            Product p2 = new Product("Mobile", "Samsung Galaxy S7", 300);
            Product p3 = new Product("Tablet", "Apple iPad Air 2", 400);
            Product p4 = new Product("Camera", "Canon EOS 5D Mark III", 700);
            Product p5 = new Product("TV", "Sony Bravia 55", 1000);
            // Array of Products
            Product[] products = {p1, p2, p3, p4, p5};
            // Print all products
            foreach(Product p in products){
                // Print product details
                p.PrintDetails();
                Console.WriteLine();
            }
        }
        public class Product{
            public string Name;
            public string Description;
            public decimal Price;
            public Product(string Name, string Description, decimal Price){
                this.Name = Name;
                this.Description = Description;
                this.Price = Price;
            }
            public void PrintDetails(){
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Description: {0}", Description);
                Console.WriteLine("Price: {0}", Price);
            }
        }
    }
}