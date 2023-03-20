using System;
namespace AbstractClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Shape shape = new Circle();
            //override
            shape.GetArea2(); //GetArea2 but in Circle
            circle.GetArea2(); //GetArea2 but in Circle
            //method hiding
            shape.GetArea3(); //GetArea3
            circle.GetArea3(); //GetArea3 but in Circle


            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();
        public virtual void GetArea2() {
            Console.WriteLine("This is virtual GetArea2");
        }
        public virtual void GetArea3 () {
            Console.WriteLine("GetArea3");
        }
        public void GetArea4() {
            Console.WriteLine("GetArea4");
        }
    }


    public interface IShape  {
        double GetArea(int a);
    }


    class Circle : Shape, IShape {
        public override double GetArea()
        {
            return 22/7;
        }
        public override void GetArea2()
        {
            Console.WriteLine("GetArea2 but in Circle");
        }
        public new void GetArea3()
        {
            Console.WriteLine("GetArea3 but in Circle");
        }
        public double GetArea(int a)
        {
            return 22/7;
        }
    }
}
