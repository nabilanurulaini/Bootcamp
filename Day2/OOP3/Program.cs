using System;
namespace OOP3{
    class OOP3
    {
        private string Name;
        private string Description;
        private decimal Price;
        public string name
        {
            get { 
                // this will return the value of Name
               return Name;
                

                }
            set { 
                Name = value;
                Description = value;
                Price = value; 
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOP3 p1 = new OOP3();
            p1.Name = "Laptop";
            p1.Description = "Dell Inspiron 15";
            p1.Price = 500;
            Console.WriteLine("Name: {0}", p1.Name);
            Console.WriteLine("Description: {0}", p1.Description);
            Console.WriteLine("Price: {0}", p1.Price);
        }
    }
}