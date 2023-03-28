using System;
public struct Point{
    public int X {get; set;}
    public int Y {get; set;}
    public Point(int x, int y){
        X = x;
        Y = y;
    }
    //Point sebgai tipe data
    public static Point operator + (Point a, Point b){
        return new Point(a.X + b.X, a.Y + b.Y);
    }
    public static Point operator - (Point a, Point b){
        return new Point(a.X - b.X, a.Y - b.Y);
    }
    public static bool operator == (Point a, Point b){
        return a.X == b.X && a.Y == b.Y;
    }
    public static bool operator != (Point a, Point b){
     
        return a.X != b.X || a.Y != b.Y;
    }
   public static bool operator > (Point a, Point b){
        return a.X > b.X && a.Y > b.Y;
    }
    public static bool operator < (Point a, Point b){
        return a.X < b.X && a.Y < b.Y;
    }
    public static bool operator >= (Point a, Point b){
        return a.X >= b.X && a.Y >= b.Y;
    }
    public static bool operator <= (Point a, Point b){
        return a.X <= b.X && a.Y <= b.Y;
    }
    
    
    
}
class Program
{
    static void Main(string[] args)
    {
        Point a = new Point(10, 20);
        Point b = new Point(30, 40);
        Point c = a + b;
        Point d = a - b;
        Console.WriteLine(c.X);
        Console.WriteLine(c.Y);
        Console.WriteLine(d.X);
        Console.WriteLine(d.Y);
        
        Console.WriteLine("a==b = "+a==b);
        Console.WriteLine("a!=b = "+a!=b);
        Console.WriteLine(a>b);
        Console.WriteLine(a<b);
        Console.WriteLine(a>=b);
        Console.WriteLine(a<=b);
        
    }
}