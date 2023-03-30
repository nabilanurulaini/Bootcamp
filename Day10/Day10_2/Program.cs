using System;
using System.Collections;
class Program{
    static void Main(){
        ArrayList MyArrayList = new ArrayList();
        MyArrayList.Add("Apple");
        MyArrayList.Add("Mango");
        MyArrayList.Add("Orange");
        MyArrayList.Add("Banana");
        foreach (var item in MyArrayList)
        {
            Console.WriteLine(item);
        }

        //untuk sort array list using .Sort
        MyArrayList.Sort();
        Console.WriteLine("After sorting");
        foreach (var item in MyArrayList)
        {
            Console.Write(item + ", ");
        }
        MyArrayList.Reverse();
        Console.WriteLine("\nAfter sorting in descending order");
        foreach (var item in MyArrayList)
        {
            Console.Write(item + ", ");
        }

    }
}