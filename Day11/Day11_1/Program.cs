using System;
using System.Collections;
class Program{
    static void Main(){
        Console.WriteLine("HashSet");
        HashSet<string> set = new HashSet<string>();

        set.Add("apple");
        set.Add("mango");
        set.Add("orange");
        
        //to check if the set contains a specific value
        Console.WriteLine(set.Contains("apple")); // true
        Console.WriteLine(set.Contains("grape")); // false

        foreach (string item in set)
        {
            Console.Write(item+",");
        }

        Console.WriteLine("HashTable");
        Hashtable OnlineShop = new Hashtable();
        Queue addOnlineShop = new Queue();


        OnlineShop.Add("food", "Pizza, Burger, Salad");
        OnlineShop.Add("drink", "Milk, Tea, Coffee");
        OnlineShop.Add("fashion", "Shirt, Pants, Shoes");
        OnlineShop["food"] += ", Noodle";
        
        //melakukan perlangan setiap item yang ada dalam OnlineShop, Dictionary Entry dapat digunakan untuk mengakses key dan value secara bersamaan dan bisa diganti dengan var
        foreach(DictionaryEntry item in OnlineShop){
            Console.WriteLine(item.Key + " : " + item.Value);
        }
        // Console.WriteLine(OnlineShop["Food"]);
        Console.WriteLine("Input which category you want to see: ");
        string input = Console.ReadLine().ToLower();
        
        if(OnlineShop.Contains(input))
        {
            //this will print the value of key yang diinputkan
            Console.WriteLine("In food category ada : "+OnlineShop[input]);
        }
        
        else
        {
            Console.WriteLine("Category not found");
        }

    }
}