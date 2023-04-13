using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting program");

        //task generic type dengan return value string
        Task<string> task = Task.Run(() => DoSomeWorkWithAsync());

        
        string result = await task;
        Console.WriteLine(result);

        if (task.IsCompleted)
        {
            Console.WriteLine("Task is completed");
        }
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }

    static async Task<string> DoSomeWorkWithAsync()
    {
        Console.WriteLine("Task is running");
        await Task.Delay(3000); 
        return "Task completed success!";
    }
}
