using System;

namespace BuilderDesignPatternExample {
    //create a cake factory that creates cakes with or without chocolate and fruit
    // Factory Method Interface defines the factory method for creating cakes 
    public interface ICakeFactory {
        Cake CreateCake(string name, int size, bool hasChocolate, bool hasFruit);
    }
    
    //implement factory method interface untuk membuat kue dengan atau tanpa coklat dan buah
    // Concrete Factory is the class that implements the factory method interface
    public class CakeFactory : ICakeFactory {
        public Cake CreateCake(string name, int size, bool hasChocolate, bool hasFruit) {
            CakeBuilder builder = new CakeBuilder();
            CakeMaker maker = new CakeMaker(builder);

            maker.SetName(name);
            maker.SetSize(size);
            maker.SetChocolate(hasChocolate);
            maker.SetFruit(hasFruit);

            return builder.GetCake();
        }
    }
    //create builder 
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

        public void SetName(string name) {
            _builder.SetName(name);
        }

        public void SetSize(int size) {
            _builder.SetSize(size);
        }

        public void SetChocolate(bool hasChocolate) {
            _builder.SetChocolate(hasChocolate);
        }

        public void SetFruit(bool hasFruit) {
            _builder.SetFruit(hasFruit);
        }
    }

    // Client as Main Program
    static class Program {
        static void Main(string[] args) {
            //initialize factory and create cakes
            ICakeFactory factory = new CakeFactory();
            Cake chocolateCake = factory.CreateCake("Chocolate Cake", 10, true, false);
            Console.WriteLine(chocolateCake);

            Cake fruitCake = factory.CreateCake("Fruit Cake", 12, false, true);
            Console.WriteLine(fruitCake);
        }
    }
}
