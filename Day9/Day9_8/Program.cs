using System;
using System.Collections;
using System.Reflection;
class Program{
    static void Main(){
        //first in first out, pertama masuk jadi pertama keluar
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        foreach (int i in list)
        {
            Console.WriteLine(i);//123
        }

        //last in first out yang last dihapus, pertama masuk jadi terakhir keluar
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(4);
        int x = stack.Pop();
        foreach (int x1 in stack)
        {
            Console.WriteLine(x1+ ", ");//2,1,
        }

        //collection yang dapat diakses dengan index, value true or false, miirip bool tapi lebih efisien
        BitArray bits = new BitArray(8);
        bits[0] = true;
        bits[1] = true;
        bits.Not();
        for(int i = 0; i < bits.Length; i++)
        {
            Console.Write(bits[i] ? "1" : "0");
        }

        //kumpulan data yg tidak diurutkan, tidak ada index, tidak ada duplikasi
        Console.WriteLine("HashSet");
        HashSet<string> set = new HashSet<string>();

        set.Add("apple");
        set.Add("banana");
        set.Add("orange");

        //to check if the set contains a specific value
        Console.WriteLine(set.Contains("apple")); // true
        Console.WriteLine(set.Contains("grape")); // false

        foreach (string item in set)
        {
            Console.Write(item+",");
        }

        // Output:
        // apple
        // banana
        // orange
       //diurutkan, jika ada yg sama maka hilang
       Console.WriteLine("SortedSet"); 
        SortedSet<string> set1 = new SortedSet<string>();
        set1.Add("apple");
        set1.Add("orange");
        set1.Add("orange");

        Console.WriteLine(set.Contains("apple")); // true
        Console.WriteLine(set.Contains("grape")); // false
        foreach (string item1 in set1)
        {
            Console.Write(item1+",");
        }

        //not sorted, lebih cepat, kalu ada yg sama akan muncull SYstem.ArgumentException : An item with the same key has already been added.
        Console.WriteLine("Dictionary");
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("apple", "a red fruit");
        dict.Add("Cherry", "a red fruit");
        dict.Add("orange", "a orange fruit");
        dict.Add("mango", "a yellow fruit");
        foreach (KeyValuePair<string, string> item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        //sorted element yg sudah ada bukan dari yang ditambahkan
        // Console.WriteLine("SortedDictionary");
        // SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>(){
        //     {"apple", 3},
        //     {"banana", 1},
        //     {"orange", 2},
        //     ("grape", 4),
        // };
        // // dictionary.Add("apple", 3);
        // // dictionary.Add("banana", 1);
        // // dictionary.Add("orange", 2);

        // Console.WriteLine(dictionary.ContainsKey("apple")); // true
        // Console.WriteLine(dictionary.ContainsKey("grape")); // false

        // foreach (KeyValuePair<string, int> item1 in dictionary)
        // {
        //     Console.WriteLine(item1.Key + ": " + item1.Value);
        // }


        // Output:
        // apple: 3
        // banana: 1
        // orange: 2
        Console.WriteLine("SortedList");
        var sorted = new SortedList <string, MethodInfo>();
        foreach (MethodInfo m in typeof (object).GetMethods())
        sorted [m.Name] = m;
        foreach (string name in sorted.Keys)
        Console.WriteLine (name);
        foreach (MethodInfo m in sorted.Values)
        Console.WriteLine (m.Name + " returns a " + m.ReturnType);
    }
}