using System.Diagnostics.Contracts;

class Program
{
    static int Divide(int numerator, int denominator)
    {
        Contract.Requires(denominator != 0);
        Contract.Ensures(Contract.Result<int>() >= 0);

        int result = numerator / denominator;

        return result;
    }

    static void Main(string[] args)
    {
        int result = Divide(10, 2);
        Console.WriteLine($"Result: {result}");

        result = Divide(10, 1); // This will trigger a ContractException
        Console.WriteLine($"Result: {result}");
    }
}
