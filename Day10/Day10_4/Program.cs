using System;
class Program{
    static void Main()
    {
        List<string> list= new List<string>();
        list.Add("Apple");
        list.Add("Mango");
        list.Add("Orange");
        list.Add("Banana");
        list.Add("Pineapple");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        string[] ArrayCopy = new string[15];
        list.CopyTo(ArrayCopy);
        list.CopyTo(ArrayCopy, 1);
        list.CopyTo(2, ArrayCopy, 12, 3);
        foreach (var item in ArrayCopy)
        {
            Console.WriteLine(item);
        }
        // IList<string> list2 = (IList)list.CopyTo();
        // list2.Add("Papaya");
        // foreach (var item2 in list2)
        // {
        //     Console.WriteLine(item2);
        // }
    }
}