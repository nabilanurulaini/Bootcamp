using System;
using System.Threading;
using System.Threading.Tasks;

class Program{
    static async Task Main(string[] args){
        Console.WriteLine("Main thread started");
        await Task.Run(() => {
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Task started");
                Thread.Sleep(1000);
                Console.WriteLine("Task ended");
            }
        });
        Console.WriteLine("Main thread ended");
    }
}