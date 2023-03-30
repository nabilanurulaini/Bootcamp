using System;
using System.Collections;
class Program{
    static void Main(){
        Stack stack = new Stack();
        //insert data dengan beda  tipe data
        stack.Push("Apple");
        stack.Push("Mango");
        stack.Push(10);
        stack.Push(true);
        stack.Push(10.5M);
        //count stack
        Console.WriteLine("Stack count: " + stack.Count);
        Console.Write("stack = ");
        //foreach menggunakan object karena isi dalam stack memiliki tipe data yang berbeda
        foreach (object item in stack)
        {
            //last in first out
            Console.WriteLine(item);
        }
        //mengeluarkan data dari stack dengan menggunakan pop, last paling keluar awal
        Console.WriteLine("Pop: " + stack.Pop());
        // stack generic
        
        Stack<string> stack2 = new Stack<string>();
        stack2.Push("Tshirt");
        stack2.Push("Pants");
        stack2.Push("Shoes");
        stack2.Push("Hat");
        Console.WriteLine("Stack count: " + stack2.Count);
        Console.Write("stack2 : ");
        foreach (var item2 in stack2)
        {
            Console.Write(item2 + ", ");
        }
        //yang dipeek adalah yang paling terakhr(pertama keluar dari stack)
        Console.WriteLine("\nPeek Stack: " + stack2.Peek());


        //FIrst in first out
        Queue queue = new Queue();
        queue.Enqueue("Pizza");
        queue.Enqueue("Burger");
        queue.Enqueue("Fries");
        queue.Enqueue("Soda");
        Console.WriteLine("Queue count: " + queue.Count);
        Console.Write("queue : ");
        foreach (var item3 in queue)
        {
            Console.Write(item3 + ", ");
        }
        Console.WriteLine("\nDequeue: " + queue.Dequeue());
        Console.WriteLine("Queue count: " + queue.Count);
        Console.Write("queue : ");
        foreach (var item3 in queue)
        {
            Console.Write(item3 + ", ");
        }
    }
}