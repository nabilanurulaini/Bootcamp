using System;
namespace BuilderDesignPatternExampleWrong;
public class Cake
{
    public string Name { get; }
    public int Size { get; }
    public bool HasChocolate { get; }
    public bool HasFruit { get; }

    public Cake(string name)
        : this(name, 8)
    {
    }

    public Cake(string name, int size)
        : this(name, size, false)
    {
    }

    public Cake(string name, int size, bool hasChocolate)
        : this(name, size, hasChocolate, false)
    {
    }

    public Cake(string name, int size, bool hasChocolate, bool hasFruit)
    {
        Name = name;
        Size = size;
        HasChocolate = hasChocolate;
        HasFruit = hasFruit;
    }

    public override string ToString()
    {
        return $"Cake: {Name}, Size: {Size}, HasChocolate: {HasChocolate}, HasFruit: {HasFruit}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        var cake1 = new Cake("Chocolate Cake");
        Console.WriteLine(cake1.ToString());

        var cake2 = new Cake("Chocolate Cake", 10);
        Console.WriteLine(cake2.ToString());

        var cake3 = new Cake("Chocolate Cake", 10, true);
        Console.WriteLine(cake3.ToString());

        var cake4 = new Cake("Chocolate Cake", 10, true, true);
        Console.WriteLine(cake4.ToString());



    }
}