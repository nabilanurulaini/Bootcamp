using System;
class Program{
    static async Task Main()
    {
        Task<int> primeNumberTask = Task.Run (() =>
        Enumerable.Range (2, 3000000).Count (n => 
        Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));
        // Console.WriteLine("Task is running");
        // Console.WriteLine("The number of prime number between 2 and 3,000,000 is {0}", primeNumberTask.Result);
        var awaiter = primeNumberTask.GetAwaiter();
        awaiter.OnCompleted(() => {
            Console.WriteLine("Task is running");
            Console.WriteLine("The number of prime number between 2 and 3,000,000 is {0}", awaiter.GetResult());
        }); 
        await Task.Delay(1000);
        Console.ReadKey();
    }
}