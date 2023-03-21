using System;

namespace RefOutInDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z;
            int q = 5;

            Add(ref x, ref y);
            Console.WriteLine($"After Add method, x={x}, y={y}");

            Subtract(out x, out z);
            Console.WriteLine($"After Subtract method, x={x}, y={z}");

            z = Multiply(in x, in q);
            Console.WriteLine($"After Multiply method, z={z}");

            q = Divide(in x, in z);
        }

        static void Add(ref int a, ref int b)
        {
            a++;
            b++;
        }

        static void Subtract(out int a, out int b)
        {
            a = 10;
            b = 20;
            a--;
            b--;
        }

        static int Multiply(in int a, in int b)
        {
            return a * b;
        }

        static int Divide(in int a, in int b)
        {
            return a / b;
        }
    }
}
