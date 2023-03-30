using System;
using System.Collections.ObjectModel;
namespace TryCollection2{
    class Program {
        static void Main(){

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
        Shop shop;
        public OnlineShopCollection(Shop shop)
        {
            this.shop = shop;
        }
        protected override  void InsertItem(int index, OnlineShop item )
        {
            base.InsertItem(index, item);
            item.Shop = shop;
        }
        protected override void SetItem(int index, OnlineShop item)
        {
            base.SetItem(index, item);
            item.Shop = shop;
        }
        protected override void RemoveItem(int index)
        {
            this[index].Shop = null;
            base.RemoveItem(index);
        }
        protected override void ClearItems()
        {
            //this ke OnlineShopCollection : Collection<OnlineShop>
            foreach (OnlineShop item in this)
            {
                item.Shop = null;
            }
            base.ClearItems();
        }
    }
    public class Shop
    {
        public readonly OnlineSHopCollection Product;
        //membuat constructor untuk class Shop
        public Shop()
        {
            //public class shop ke dalam class OnlineShopCollection
            Product = new OnlineSHopCollection(this);
        }
    }
}