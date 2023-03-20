using System;

namespace Day3._1{
public abstract class AbstractAnimal
{
    protected int _x = 2;
    protected int _y = 3;
    public abstract void AbstractMethod();
    public abstract int X{get;}
    public abstract int Y{get;}
}
interface IAnimal
{
    //this declare a method called Speak
    string Speak();
    string Name();
    int Legs();
}
// interface ILegs
// {
//     //this declare a property called Legs
//     int Legs { get; }
// }
class Chicken : IAnimal
{
    // public override void AbstractMethod()
    // {
    //     //this is the implementation of the AbstractMethod
    //     //it is required to be implemented and Abstract Method harus diletakkan before any interface
    //     _x++;
    //     _y++;
    // }
    // public override int X
    // {
    //     get
    //     {
    //         return _x;
    //     }
    // }
    // public override int Y
    // {
    //     get
    //     {
    //         return _y;
    //     }
    // }

        //this is the implementation of the Speak method
    public string Speak()
    {
        return " Petok Petok";
    }
    public int Legs()
    {
        return 2;
    }
    public string Name()
    {
        return "Chicken";
    }
}
class Dog : IAnimal
{
    // public override void AbstractMethod()
    // {
    //     //this is the implementation of the AbstractMethod
    //     //it is required to be implemented and Abstract Method harus diletakkan before any interface
    //     _x++;
    //     _y++;
    // }
    // public override int X
    // {
    //     get
    //     {
    //         return _x;
    //     }
    // }
    // public override int Y
    // {
    //     get
    //     {
    //         return _y;
    //     }
    // }

        //this is the implementation of the Speak method
    public string Speak()
    {
        return " Woof Woof";
    }
    public int Legs()
    {
        return 4;
    }
    public string Name()
    {
        return "Dog";
    }
}


static class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        Chicken c = new Chicken();
        IAnimal a = d;
        Console.WriteLine("Input 1 for Dog and 2 for Chicken");
        int input = Convert.ToInt32(Console.ReadLine());
        switch(input)
        {
            case 1:
            a = d;
            Console.WriteLine("This is a dog and has "+a.Legs()+" legs and it says"+a.Speak());
            break;

            case 2:
            a = c;
            Console.WriteLine("This is a chicken and has "+a.Legs()+" legs and it says"+a.Speak());
            break;
        }
        // d.AbstractMethod();
        // Console.WriteLine("X = {0}, Y = {1}", d.X, d.Y);
        Console.ReadKey();
    }
}
}
