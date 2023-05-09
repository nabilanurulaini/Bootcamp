using System;
namespace BuilderDesignPatternExample;

// Builder Interface defines the steps to build the product
public interface IBuilder
{
    void SetName(string name);
    void SetSize(int size);
    //setchocolate dan setfruit direplace dengan settopping
    void AddTopping(string topping);
}

// Concrete Builder is the class that implements the builder interface for cake
public class CakeBuilder : IBuilder
{
    private string _name;
    private int _size;
    private List<string> _toppings = new List<string>();


    public void SetName(string name)
    {
        _name = name;
    }

    public void SetSize(int size)
    {
        _size = size;
    }

    public void AddTopping(string topping)
    {
        _toppings.Add(topping);
    }

    public Cake GetCake()
    {
        return new Cake(_name, _size, _toppings);
    }
}
//add concrete builder for drink
public class DrinkBuilder : IBuilder
{
    private string _name;
    private int _size;
    private List<string> _toppings = new List<string>();
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetSize(int size)
    {
        _size = size;
    }
    public void AddTopping(string topping)
    {
        _toppings.Add(topping);
    }
    public Drink GetDrink()
    {
        return new Drink(_name, _size, _toppings);
    }
}
//add product for drink
public class Drink
{
    public string Name { get; set; }
    public int Size { get; set; }
    public List<string> Toppings { get; set; }

    public Drink(string name, int size, List<string> toppings)
    {
        Name = name;
        Size = size;
        Toppings = toppings;
    }

    public override string ToString()
    {
        return $"{Name} (size {Size}), with {string.Join(", ", Toppings)}";
    }
}

// Products is the object that the builder will build
public class Cake
{
    public string Name { get; set; }
    public int Size { get; set; }
    public List<string> Toppings { get; set; }

    public Cake(string name, int size, List<string> toppings)
    {
        Name = name;
        Size = size;
        Toppings = toppings;
    }

    public override string ToString()
    {
        return $"{Name} (size {Size}), with {string.Join(", ", Toppings)}";
    }
}

//add director for drink
public class DrinkMaker
{
    private IBuilder _builder;

    public DrinkMaker(IBuilder builder)
    {
        _builder = builder;
    }

    public void MakeDrink(string name, int size)
    {
        _builder.SetName(name);
        _builder.SetSize(size);
        _builder.AddTopping("Ice");
        _builder.AddTopping("Sugar");
    }
}

// Director Class to build the products and control the builder 
public class CakeMaker {
        private IBuilder _builder;

        public CakeMaker(IBuilder builder) {
            _builder = builder;
        }

        public void MakeCake(string name, int size) {
            _builder.SetName(name);
            _builder.SetSize(size);
            _builder.AddTopping("Meises");
            _builder.AddTopping("Flake");
        }
    }

// Client as Main Program
class Program
{
    static void Main(string[] args)
    {
        //initialize builder and director
        CakeBuilder cakebuilder = new CakeBuilder();
        CakeMaker cakemaker = new CakeMaker(cakebuilder);

        DrinkBuilder drinkbuilder = new DrinkBuilder();
        DrinkMaker drinkmaker = new DrinkMaker(drinkbuilder);

        cakemaker.MakeCake("Chocolate Cake", 10);
        Cake chocolateCake = cakebuilder.GetCake();
        Console.WriteLine(chocolateCake);

        cakemaker.MakeCake("Fruit Cake", 12);
        cakebuilder.AddTopping("Buttercream");
        Cake fruitCake = cakebuilder.GetCake();
        Console.WriteLine(fruitCake);

        drinkmaker.MakeDrink("Milk Tea", 20);
        Drink milkTea = drinkbuilder.GetDrink();
        Console.WriteLine(milkTea);

        drinkmaker.MakeDrink("Green Tea", 16);
        drinkbuilder.AddTopping("Honey");
        Drink greenTea = drinkbuilder.GetDrink();
        Console.WriteLine(greenTea);
    }
}
