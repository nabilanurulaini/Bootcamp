// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args)
    {
        Console.Write("Input text = ");
        string name = Console.ReadLine();
        string reverse = "";
        for(int i = name.Length - 1; i >= 0; i--)
        {
            reverse += name[i];
        }
        Console.WriteLine("Reversed Word = " +reverse);
        Console.WriteLine("Count Reversed Word = "+reverse.Length);
        
        // char[] charArray = name.ToCharArray();
        // Array.Reverse(charArray);
        // Console.WriteLine(charArray);
    }
}
