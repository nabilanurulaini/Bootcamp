using System;
class Program
{
    static void Main()
    {
        string s = true.ToString(); // s = "True"
        bool b = bool.Parse (s); // b = true
        bool success = int.TryParse ("123", out int _);
        Console.WriteLine(success); // True
    }
}