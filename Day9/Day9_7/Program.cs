using System;
using System.Globalization;
class Program{
    static void Main(){
        //offset must be between -14:00 and +14:00
        var dt1 = new DateTimeOffset (2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
        var dt2 = new DateTimeOffset (2010, 1, 1, 2, 1, 1, TimeSpan.FromHours(9));
        Console.WriteLine (dt1 == dt2); // True

        //comparison made to sam variable, did you mean to compare something else?
        double x = double.NaN;
        Console.WriteLine (x == x); // False
        Console.WriteLine(x.Equals(x)); // False

        // //akan menghasilkan false karena x1 dan y1 memiliki value yang berbeda
        int x1 = 5;
        int y1 = 10;
        Console.WriteLine (x1 == y1); // False
        //
        Console.Write("ini",x1.Equals(y1)); // False

       
        // operator == tidak dapat digunakan karena str1 dan str2 adalah objek dari class string, bukan tipe data primitif.
        // string str1 = "Hello";
        // string str2 = "Hello";
        // if (str1.Equals(str2))
        // {
        //     Console.WriteLine("str1 equals str2");
        // }
        string str1 = "Hello";
        string str2 = "ayam";
        if (str1==str2)
        {
            Console.WriteLine("str1 equals str2");
        }

    }
}