using System;
namespace Day7_5{
    static class Program{
        static void Main(string[] args){
            ProcessBusinessLogic p = new ProcessBusinessLogic();
            p.ProcessCompleted += Subscriber.B1_ProcessCompleted;
            p.StartProcess();

            // var calculator = new Calculator();
            // var subscriber1 = new Subscriber1();
            // var subscriber2 = new Subscriber2();
            // calculator.Calculated += subscriber1.CalculatedHandler;
            // calculator.Calculated += subscriber2.CalculatedHandler;
            // calculator.Calculated += subscriber2.CalculatedHandler2;
            // calculator.Calculate(5, 10);
        }
    }
}