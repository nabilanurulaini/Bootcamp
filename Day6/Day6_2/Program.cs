using System;
namespace Calculator{
    class Program{
        delegate T CalculatorSum<T>(T a ,  T b);
        static void Main(string[] args){
            CalculatorSum<int> addnum = MethodsCal<int>.Sum;
            Console.WriteLine(addnum(10, 20));
            
            CalculatorSum<int> multiplyNum = MethodsCal<int>.Multiply;
            Console.WriteLine(multiplyNum(10, 20));
            
            CalculatorSum<int> substractNum = MethodsCal<int>.Substraction;
            Console.WriteLine(substractNum(10, 20));
            
            // CalculatorSum<int> multiplyNum = new CalculatorSum<int>.MethodsCal.Multiply;
            // Console.WriteLine(multiplyNum(10, 20));

            // CalculatorSum<int> substarctNum = new CalculatorSum<int>.MethodsCal.Substraction;
            // Console.WriteLine(substarctNum(10, 20));
            // // CalculatorSum addNum =  new CalculatorSum(MethodsCal.Sum);
            // Console.WriteLine(addNum(10, 20));

            // CalculatorSum multiplyNum = new CalculatorSum(MethodsCal.Multiply);
            // Console.WriteLine(multiplyNum(10, 20));   

            // CalculatorSum substarctNum = new CalculatorSum(MethodsCal.Substraction);
            // Console.WriteLine(substarctNum(10, 20));

        }  
    }
}