using System;
class Program{
    static void Main(string[] args)
    {
        //to check the last word of the string, if sama then it will return true if beda then it will return false
        Console.WriteLine("Hello World!".EndsWith("World!"));
        //check the words, apakah ada yg sama atau tidak
        Console.WriteLine("Hello World!".Contains("World"));
      
        // to check apakah memiliki address yang sma atau tidak 
        string Empty = string.Empty;
        string empty = "";
        Console.WriteLine (empty == ""); // True
        
        
        char[] ca = "Hello".ToCharArray();
        string s = new string (ca); // s = "Hello" == Empty ); // True
        Console.WriteLine (empty.Length == 0); // True

        //make new string with 10 *
        Console.Write (new string ('*', 10)); // **********
        char[] a = "Hello".ToCharArray();
        string b = new string (a); // s = "Hello"
 
        //To check the index of the number in the string dan dalam index ke berapa
        Console.Write ("pas5w0rd".IndexOfAny ("0123456789".ToCharArray() )); // 3

        string input = " quick brown fox ";
        //menghilangkan spasi di depan dan belakang
        string trimmedInput = input.Trim();
        Console.WriteLine(trimmedInput); // "quick brown fox"

        //mengisi dengan bintang sisanya hingga index ke 20
        string paddedInput = input.PadRight(20, '*'); // " quick brown fox ***"
        Console.WriteLine(paddedInput);

        // mengisi spasi dengan |
        string replacedInput = input.Replace(" ", "|"); // "| | |quick|brown|fox| | "
        Console.WriteLine(replacedInput);

        //membuat huruf besar semua tapi lebih untuk huruf dengan tanda tanda diatas atau seperti e dan e ada garis atasnya
        string uppercaseInput = input.ToUpperInvariant(); // " QUICK BROWN FOX "
        Console.WriteLine(uppercaseInput);

        // membuat huruf kecil semua
        string lowercaseInput = input.ToLower(); // " quick brown fox "
        Console.WriteLine(lowercaseInput);

        //mengambil string dari index ke 5 sampai index ke 10
        string substringInput = input.Substring(5, 10); // "brown fox"
        Console.WriteLine(substringInput);



    }
}