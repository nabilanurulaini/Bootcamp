using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var DictionaryTry = new Dictionary<int, string>(){
			{3, "Foo"},
			{5, "Bar"},
		};
        Console.WriteLine("Input a number: ");

        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {

            if(DictionaryTry.ContainsKey(i)){
                Console.Write(DictionaryTry[i]+", ");
            }
            else{
                Console.Write(i+", ");
            }
            // if(i==0)
            // {
            //     Console.Write(i+", ");
            // }
            // else if(1%3==0){
            //     Console.Write(DictionaryTry[3]+", ");
            // }
            // else if(i%5==0)
            // {
            //     Console.Write(DictionaryTry[5]+", ");
            // }
            // else if(i%3==0 && i%5==0){
            //     Console.Write("FooBar, ");
            // }
            // else
            // {
            //     Console.Write(i+", ");
            // }
            //Console.WriteLine(DictionaryTry.ElementAt(i).Value);
        }
    }
}