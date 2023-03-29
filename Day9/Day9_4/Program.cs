using System;
using System.Globalization;
class Program{
    static void Main()
    {
        //string s adalah true kemudian diparse kedalam bool b, 
        //sehingga nilai bool b jadi true. kemudian akan mencoba parse 123 ke dalam string to int, karena dapat di parse sehingga bool success bernilai true
        string s = true.ToString(); // s = "True"
        bool b = bool.Parse (s); // b = true
        bool success = int.TryParse ("123", out int _);
        Console.WriteLine(success); // True
        
        string a = true.ToString(); // a = "True"
        bool c = bool.Parse (a); // c = true
        bool success1 = int.TryParse ("ayam", out int _);
        Console.WriteLine(success1); // false

        NumberFormatInfo f = new NumberFormatInfo();
        f.CurrencySymbol = "$$";
        Console.WriteLine (3.ToString ("C", f)); // $$ 3.00
        // ------- //
        int value = 123456;
        string template = "The value is {0:C}.";
        string result = string.Format(new CultureInfo("en-US"), template, value);
        Console.WriteLine(result); //"The value is $123,456.00."

        //membuat 3 angka dibelakang titik, bisa diubah pada n
        f.NumberGroupSeparator = " ";
        //dibulatkan ke atas sehingga angka 8 menjadi 9
        Console.WriteLine (12345.6789.ToString ("N3", f)); // 12 345.679



        
    }
}