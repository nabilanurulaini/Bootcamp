using System;
class Program{
    static void Main(string[] args){
        int a = 10;
        int b = 0;
        try{
            int c = a / b;
        }
        catch (Exception e){
            Console.WriteLine("DivideByZeroException");
        }
        catch (DivideByZeroException e){
            Console.WriteLine("Exception");
        }
        finally{
            Console.WriteLine("Finally");
        }
    }
}
