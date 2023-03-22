using System;
using System.Collections;
//method 1
public class OnlineShop{
    // Constructor
    public OnlineShop(string Product, int Price){
        //catch value dari parammeter string Product dan Price
        this.Product = Product;
        this.Price = Price;
    }
    public string Product;
    public int Price;
}
public class Shopee : IEnumerable
{
    private OnlineShop[] _shopee;
    public Shopee(OnlineShop[] ShopeeArray){
        //catch value dari ShopeeArray
        _shopee = new OnlineShop[ShopeeArray.Length];

        for(int i = 0; i < ShopeeArray.Length; i++){
            _shopee[i] = ShopeeArray[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator(){
        //enumerator to produce enumerable hasilnya
        return GetEnumerator();
    }
    public ShopeeEnum GetEnumerator(){
        return new ShopeeEnum(_shopee);
    }
}

public class ShopeeEnum : IEnumerator
{
    public OnlineShop[] _shopee;
    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;
    public ShopeeEnum(OnlineShop[] list){
        _shopee = list;
    }
    public bool MoveNext(){
        position++;
        return position < _shopee.Length;
    }
    public void Reset(){
        position = -1;
    }
    object IEnumerator.Current{
        get{
            return Current;
        }
    }
    public OnlineShop Current
    {
        get
        {
            try
            {
                return _shopee[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
class App
{
    static void Main()
    {
        //initiate OnlineShop dengan array size 3
        OnlineShop[] ShopeeArray = new OnlineShop[3]
        {
            new OnlineShop("Baju", 100000),
            new OnlineShop("Celana", 50000),
            new OnlineShop("Sepatu", 200000),
        };
        foreach (OnlineShop o in new Shopee(ShopeeArray)){
            Console.WriteLine(o.Product + " " + o.Price);
        }
        Console.ReadLine();
    }
}