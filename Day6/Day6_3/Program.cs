//delegate
using System;
using System.Collections.Generic;
    class Program {
        static void Main(string[] args){
             Dictionary<string, string> ConvertDictionary = new()
            {
                {"Food", "Banana, Mango"},
                {"Drink", "Water, Tea"},
                {"Fashion", "T-Shirt, Jeans"},
                {"Furniture", "Chair, Table"},
                {"Electronic", "Laptop, Mobile"},
            };
            DelegateOnlineShop<string?, int?> delegateOnlineShop = MethodsOnlineShop<string?,int?>.GetProduct;
            Console.WriteLine("Input Product Name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Input Product Quantity: ");
            int? quantity = Convert.ToInt32(Console.ReadLine());

         //   string? resultQuantity = Console.ReadLine();
            //string userInput = "a sweet fruit";
            //Console.WriteLine(delegateOnlineShop(resultName, 10000, Convert.ToInt32(resultQuantity)));
            //Console.WriteLine("Total Price = ")
            bool isUserInputInValues = false;
            foreach (string value in ConvertDictionary.Values)
            {
                if(name == value)
                {
                    isUserInputInValues = true;
                    break;
                }
            }

            // Print the result
            if (isUserInputInValues)
            {
                Console.WriteLine("User input is in dictionary values.");
            }
            else
            {
                Console.WriteLine("User input is not in dictionary values.");
            }
        }
    }
