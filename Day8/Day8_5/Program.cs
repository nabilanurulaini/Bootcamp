using System;
class Program{
    static void Main(string[] args)
    {
        try
        {
            // outer try block
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            try
            {
                // inner try block
                Console.WriteLine("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input for the second number!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input for the first number!");
        }

    }
}