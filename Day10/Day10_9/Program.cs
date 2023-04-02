using System;
using System.Collections.ObjectModel;
namespace TryCollection2{
    class Program {
        static void Main(){
            OnlineShop os = new OnlineShop();
            os.Product.Add (new OnlineShop ("Chicken", 10));
            os.Product.Add (new OnlineShop ("Panda", 20));
            foreach (Animal a in zoo.Product)
            {
                Console.WriteLine (a.Name);
            }
        }

    }
    class OnlineShop
    {
        public string ProductName;
        public int ProductPrice;
        //membuat constructor untuk class OnlineShop
        public OnlineShop(string name, int price)
        {
            ProductName = name;
            ProductPrice = price;
        }
    }
    public class OnlineShopCollection : Collection<OnlineShop>
    {
        //tidak diisi karena sudah ada di class Collection

    }
    public class Shop
    {
        public readonly OnlineShopCollection Product = new OnlineShopCollection();
        //membuat constructor untuk class Shop
    }
}