using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Numbers.AddNumber(3, "foo");
        Numbers.AddNumber(5, "bar");
        foreach(var i in Numbers)
        {
            Console.WriteLine(Numbers.Key);
        }
    }
}

class Numbers{
    SortedDictionary<int, string> _dictionary = new SortedDictionary<int, string>;
    public static void AddNumber(int number, string words){
        _dictionary.TryAdd(number, words);
    }
}