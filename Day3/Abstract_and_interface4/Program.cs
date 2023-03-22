using System;
abstract class Abstract_OnlineShop
{
    public abstract void AbstractOnlineShop_Method();
}
interface Ionlineshop
{
    string[] Product();
    string[] Price();
    string[] Stock();
    string[] Brand();
}

class Food : Abstract_OnlineShop, Ionlineshop
{
    string[] ProductList={"Sari Roti","Frisian Flag","Indomaret","Blue Band"};
    string[] PriceList={"Rp. 10.000","Rp. 20.000","Rp. 30.000","Rp. 40.000"};
    string[] StockList={"10","20","30","40"};
    string[] BrandList={"Sari Roti","Frisian Flag","Indomaret","Blue Band"};
    public override void AbstractOnlineShop_Method()
    {
        Console.WriteLine("This is the implementation of the AbstractOnlineShop_Method");
    }
    public string[] Product()
    {
        return ProductList;
    }
    public string[] Price()
    {
        return PriceList;
    }
    public string[] Stock()
    {
        return StockList;
    }
    public string[] Brand()
    {
        return BrandList;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Food food = new Food();
        food.AbstractOnlineShop_Method();
        for (int i = 0; i < food.Product().Length; i++)
        {
            Console.WriteLine("\nProduct Number = "+(i+1));
            Console.WriteLine("Product Name = "+food.Product()[i]);
            Console.WriteLine("Price = "+food.Price()[i]);
            Console.WriteLine("Stock = "+food.Stock()[i]);
            Console.WriteLine("Brand = "+food.Brand()[i]);   
        }
        Console.WriteLine("Choose the product you want to buy (1-4)");
        int InputProduct = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many product do you want to buy?");
        int InputCount = Convert.ToInt32(Console.ReadLine());
        int CountStock = Convert.ToInt32(food.Stock()[InputProduct-1]);
        if(InputProduct!=0)
        {
            //dikurang 1 bcs array start from 0 and product number start from 1
            if(InputCount>CountStock)
            {
                Console.WriteLine("Sorry, we don't have enough stock");
            }
            else
            {
                Console.WriteLine("You have chosen "+food.Product()[InputProduct-1]);
                Console.WriteLine("The price is "+food.Price()[InputProduct-1]*CountStock);
            }


        }
    }
}