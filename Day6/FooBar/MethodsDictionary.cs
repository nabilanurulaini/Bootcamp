namespace FooBar;

class CheckDictionary
{
    private SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
    private int input;

    public void Add(int key, string value)
    {
        dict.TryAdd(key, value);
        Console.WriteLine("Key = "+key + ", Value " + value + " successfully added");
    }

    public void SetLimit(int input)
    {
        this.input = input;
    }
    public void Remove(int key)
    {
        dict.Remove(key);
        Console.WriteLine("Key = " + key + " successfully removed");
    }

    public void Print()
    {
        Compare comparer = new Compare(dict);
        for (int i = 0; i <= input; i++)
        {
            if(i == 0)
                Console.Write(i + " ");
            else
                Console.Write(comparer.DoCompare(i) + " ");
        }
    }
}

class Compare
{
    private SortedDictionary<int, string> dict;
    public Compare(SortedDictionary<int, string> dict)
    {
        this.dict = dict;
    }

    public string DoCompare(int input)
    {
        string result = "";
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            if (input % kvp.Key == 0)
            {
                result += kvp.Value;
            }
        }
        if (result == "")
        {
            result = input.ToString();
        }
        return result;
    }
}

