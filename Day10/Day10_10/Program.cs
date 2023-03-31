using System;
using System.Collections.Immutable;
class Program{
    static void Main()
    {
        ImmutableArray<int> arr = ImmutableArray.Create(1, 2, 3, 4, 5);
        ImmutableArray<int> arr2 = arr.Add(6);
        ImmutableArray<int> arr3 = arr2.Insert(0, 0);
        ImmutableArray<int> arr4 = arr3.Remove(1);
        ImmutableArray<int> arr5 = arr4.RemoveAt(0);
        ImmutableArray<int> arr6 = arr5.Replace(2, 20);
        ImmutableArray<int> arr7 = arr6.SetItem(0, 100);
        Console.WriteLine("arr: " + string.Join(", ", arr));
        //add 6 dengan immutable array baru yaitu arr 2 karena tidak bisa diedit
        Console.WriteLine("arr2: " + string.Join(", ", arr2));
        //insert 0 di index 0 dengan mmebuat immutable array baru yaitu arr3
        Console.WriteLine("arr3: " + string.Join(", ", arr3));

        //imitiate arr menjadi bulder untuk menambahkan item, remove dengan index
        ImmutableArray<int>.Builder builder = arr.ToBuilder();
        builder.Add(6);
        builder.Insert(0, 0);
        builder.Remove(1);
        Console.WriteLine("builder: " + string.Join(", ", builder));
    }
}