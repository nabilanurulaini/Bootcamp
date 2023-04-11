class Program
{
    static void Main(string[] args)
    {
    
        // Create a new instance of the DisposableClass class
        DisposableClass myDisposableObject = new DisposableClass();

        // panggil method dosomething()
        myDisposableObject.DoSomething();

        // panggil method dispose() utk clean resource yg ada
        myDisposableObject.Dispose();

        // Set the object reference ke null untuk menandai kalau sdh selasai
        myDisposableObject = null;

    }
}


class DisposableClass : IDisposable
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }

    public void Dispose()
    {
        // clean resource yg dipakai
        Console.WriteLine("Cleaning up resources...");
    }
}
