using System;
using System.Collections;
class Program{
    static void Main(){
        Queue queue = new Queue();
        queue.Enqueue("Hello", "World");
        queue.Dequeue();
    }
}