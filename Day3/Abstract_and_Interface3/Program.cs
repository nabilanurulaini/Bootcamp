using System;
  
// Abstract class
abstract class Abstract_class
{
      
    // Method declaration for abstract class
    public abstract void abstract_method();
}
  
// Parent class
class GFG : Abstract_class
{
      
    // Method definition for abstract method
    public override void abstract_method()
    {
        Console.WriteLine("Abstract method is called");
    }
}
  
// First child class extends parent
class GFG2 : GFG
{
      
    // Method definition
    public void Mymethod1()
    {
        Console.WriteLine("Method from GFG2 class");
    }
}
  
// Second child class extends first child class
class GFG3 : GFG2
{
      
    // Method definition
    public void Mymethod2()
    {
        Console.WriteLine("Method from GFG3 class");
    }
}
  
class Geeks{
      
// Driver code
public static void Main(String[] args)
{
      
    // Creating an object of GFG3 class
    GFG3 obj = new GFG3();
      
    // Call the methods using GFG3 class
    obj.abstract_method();
    obj.Mymethod1();
    obj.Mymethod2();
}
}