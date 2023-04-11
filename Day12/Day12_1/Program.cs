using System;

class Program
{
    static void Main()
    {
         // create a new instance of MyClass
        Console.WriteLine("Before garbage collection: " + GC.GetTotalMemory(false)); // print the amount of memory currently in use
        // myClass = null; // set the reference to null, making the object eligible for garbage collection
        GC.Collect(); // explicitly invoke garbage collection
        Console.WriteLine("After garbage collection: " + GC.GetTotalMemory(false)); // print the amount of memory currently in use
         // print the amount of memory currently in use
    }
}

