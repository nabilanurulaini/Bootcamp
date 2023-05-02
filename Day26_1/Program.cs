using System;
using System.Collections.Generic;
using NLog;
namespace FooBar;

class Program
{
    
    static void Main()
    {
        CheckDictionary check = new CheckDictionary();
        check.Add(3, "foo");
        check.Add(5, "bar");
        check.Add(7, "buzz");
        check.Remove(7);

        Console.WriteLine("Please enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());

        check.SetLimit(input);
        check.Print();
    }
}
