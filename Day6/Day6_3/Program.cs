//delegate
using System;
using System.Collections.Generic;
    delegate T1 DelegateOnlineShop<T1, T2>(T1 name, T2 price); 
    delegate void DelegateDictionary(Dictionary<string, string> ProductValue, string ProductKey);
    class Program {
        static void Main(string[] args){
        
             Dictionary<string, string> ConvertDictionary = new()
            {
                {"apple", "A sweet fruit"},
                {"banana", "A yellow fruit"},
                {"orange", "A round fruit"},
            };
            DelegateOnlineShop<string?, int?> delegateOnlineShop = MethodsOnlineShop<string?,int?>.GetProduct;
            string? resultName = Console.ReadLine();
            Console.WriteLine(resultName);
            string? resultQuantity = Console.ReadLine();
            //string userInput = "a sweet fruit";
            //Console.WriteLine(delegateOnlineShop(resultName, 10000, Convert.ToInt32(resultQuantity)));
            //Console.WriteLine("Total Price = ")
            bool isUserInputInValues = false;
            foreach (string value in ConvertDictionary.Values)
            {
                if (value == resultName)
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
