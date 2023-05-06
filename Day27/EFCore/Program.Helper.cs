namespace EFCore;

partial class Program
{
    //clear console
    public static void Clear()
    {
        Console.Clear();
    }
    //writle line
    public static void PrintLn(string message)
    {
        Console.WriteLine(message);
    }
    public static void Print(string message)
    {
        Console.Write(message);
    }
    //read line
    public static string GetInput()
    {
        return Console.ReadLine();
    }
    public static void PrintHeader(string header)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        PrintLn("==============================================");
        PrintLn($"\t{header}");
        PrintLn("==============================================");
        PrintLn("");
        PrintLn("");
        Console.ForegroundColor = previousColor;
    }
    //print  title with style
    public static void PrintTitle(string title)
    {

        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        PrintLn($"==================== {title} ====================");
        PrintLn("");
        Console.ForegroundColor = previousColor;
    }
    //print success with style
    public static void PrintSuccessMessage(string message)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        PrintLn("");
        Console.WriteLine($"Info > {message}");
        Console.ForegroundColor = previousColor;
    }
    //print failed message with style
    public static void PrintFailedMessage(string message)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Error > {message}");
        Console.ForegroundColor = previousColor;
    }
}
