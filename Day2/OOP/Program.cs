using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            Car car1 = new Car();
            // Call the PrintDetails method
            car1.PrintDetails();
            // Create a new instance of the Car class
            Car car2 = new Car("Toyota", "Camry", 2012, "White");
            // Call the PrintDetails method
            car2.PrintDetails();
            // Wait for user to acknowledge the results
            Console.ReadLine();
        }
    }
    public class Car
    {
        public string Make;
        string Model;
        int Year;
        string Color;
        public Car()
        {
            //this will be called when no parameters are passed
            Make = "Nissan";
            Model = "Altima";
            Year = 2010;
            Color = "Black";
        }
        public Car(string Make, string Model, int Year, string Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Make: {0}", Make);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}