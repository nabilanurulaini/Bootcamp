using System;
namespace BuilderDesignPatternExample;

// Builder Interface defines the steps to build the product
public interface ICakeBuilder {
    void SetName(string name);
    void SetSize(int size);
    void SetChocolate(bool hasChocolate);
    void SetFruit(bool hasFruit);
}

// Concrete Builder is the class that implements the builder interface
public class CakeBuilder : ICakeBuilder {
    private Cake _cake;

    public CakeBuilder() {
        _cake = new Cake();
    }

    public void SetName(string name) {
        _cake.Name = name;
    }

    public void SetSize(int size) {
        _cake.Size = size;
    }

    public void SetChocolate(bool hasChocolate) {
        _cake.HasChocolate = hasChocolate;
    }

    public void SetFruit(bool hasFruit) {
        _cake.HasFruit = hasFruit;
    }

    public Cake GetCake() {
        return _cake;
    }
}

// Products is the object that the builder will build
public class Cake {
    public string? Name { get; set; }
    public int Size { get; set; }
    public bool HasChocolate { get; set; }
    public bool HasFruit { get; set; }

    public override string ToString() {
        string chocolate = HasChocolate ? "with chocolate" : "without chocolate";
        string fruit = HasFruit ? "with fruit" : "without fruit";
        return $"{Name} (size {Size}), {chocolate}, {fruit}";
    }
}

// Director Class to build the products and control the builder 
public class CakeMaker {
    private ICakeBuilder _builder;

       public CakeMaker(ICakeBuilder builder) {
        _builder = builder;
    }

    public void MakeChocolateCake(string name, int size) {
        _builder.SetName(name);
        _builder.SetSize(size);
        _builder.SetChocolate(true);
        _builder.SetFruit(false);
    }

    public void MakeFruitCake(string name, int size) {
        _builder.SetName(name);
        _builder.SetSize(size);
        _builder.SetChocolate(false);
        _builder.SetFruit(true);
    }
}
 
// Client as Main Program
static class Program {
    static void Main(string[] args) {
        //initialize builder and director
        CakeBuilder builder = new CakeBuilder();
        CakeMaker maker = new CakeMaker(builder);

        maker.MakeChocolateCake("Chocolate Cake", 10);
        Cake chocolateCake = builder.GetCake();
        Console.WriteLine(chocolateCake);

        maker.MakeFruitCake("Fruit Cake", 12);
        Cake fruitCake = builder.GetCake();
        Console.WriteLine(fruitCake);
    }
}
