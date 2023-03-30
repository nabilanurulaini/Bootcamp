using System;
class Program{
    static void Main(){
        Product p = new Product("Apple", "100");
        Product p1 = new Product("Mango", "10");
        Product p2 = new Product("Orange", "200");
        Product p3 = new Product("Banana", "150");
        Product[] Product = {p, p1, p2, p3};
        foreach (var item in Product)
        {
            Console.WriteLine(item.name + " " + item.price);
        }
        Array.Sort(Product, (x, y) => x.price.CompareTo(y.price));
        Console.WriteLine("After sorting by price");
		foreach (var item in Product)
        {
            Console.Write(item.name + " " + item.price+", ");
        }
        Console.WriteLine("\n\nAfter sorting by name");
        Array.Sort(Product, (x1, y1) => x1.name.CompareTo(y1.name));
        foreach (var item in Product)
        {
            Console.Write(item.name + " " + item.price+", ");
        }
        Console.WriteLine("\n\nAfter sorting by name in descending order");
        Array.Sort(Product, (x2, y2) => y2.name.CompareTo(x2.name));
        foreach (var item in Product)
        {
            Console.Write(item.name + " " + item.price+", ");
        }
        Console.WriteLine("\nWhich product do you want to search?");
        string search = Console.ReadLine();
        int findProduct = Array.FindIndex(Product, x => x.name == search);
        if (findProduct == -1)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Console.WriteLine("Product found at index " + findProduct);
        }
    }
}
        
class Product{
    public string name { get; set; }
    public string price { get; set; }
    public Product(string name, string price){
        this.name = name;
        this.price = price;
    }
}


