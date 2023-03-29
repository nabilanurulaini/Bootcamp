using System;
using System.ComponentModel;
class Program{
    static void Main(){
    // karena double diubah integer dimana integer tidak bisa menerima koma sehingga dibulatkan
    double d = 3.9;
    int i = Convert.ToInt32 (d); // i == 4
    Console.WriteLine(i);

    int thirty = Convert.ToInt32 ("1E", 16); // Parse in hexadecimal (30)
    uint five = Convert.ToUInt32 ("101", 2); // Parse in binary (5)
    
    
    
    Console.WriteLine(thirty);
    Console.WriteLine(five);
    
    //tidak bisa diconvert dari dynamic y ke int karena isinya adalah string
    
    try{
        dynamic x = 123;
        string xStr = (string)x;
        Console.WriteLine(xStr);
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
    finally{
        Console.WriteLine("Finally");
    }
    
    int value = 16;
    byte[] bytes =  BitConverter.GetBytes(value);
    foreach (byte b in bytes)
        Console.Write(b);

    }


}