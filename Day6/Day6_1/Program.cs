
using System;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a number: ");

        int number = Convert.ToInt32(Console.ReadLine());
       
        for(int i = 0; i<=number; i++)
        {
            if(i==0)
            {
                Console.Write(i +", ");
            }
            else if(i%3==0 && i%5==0)
            {
                Console.Write("FooBar, ");
            }
            else if(i%3==0)
            {
                Console.Write("Foo, ");
            }
            else if(i%5==0)
            {
                Console.Write("Bar, ");
            }
            else{
                Console.Write(i +", ");
            }
        }
        
    }
}
