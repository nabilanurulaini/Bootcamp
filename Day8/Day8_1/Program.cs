using System;
namespace Day8_1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number: ");
        int input2 = int.Parse(Console.ReadLine());

        MyClass a = new MyClass(input);
        MyClass b = new MyClass(input2);

        MyClass c = new MyClass(30);
        MyClass d = new MyClass(20);

        MyClass e = new MyClass(10);
        MyClass f = new MyClass(20);

        MyClass g = new MyClass(30);
        MyClass h = new MyClass(3);

        string result = a + b;
        string result2 = c - d;
        string result3 = e * f;
        string result4 = g / h;
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
    }
}
