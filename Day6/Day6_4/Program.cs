using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> foobarDict = new Dictionary<int, string>();
        int start = 1; // Angka pertama dalam deret
        int end = 100; // Angka terakhir dalam deret

        for (int i = 0; i <= end; i++)
        {
            CheckNumber checkNumber = new CheckNumber(i);
            if (checkNumber.IsDivisibleBy(3) && checkNumber.IsDivisibleBy(5))
            {
                foobarDict.Add(i, "foobar");
            }
            else if (checkNumber.IsDivisibleBy(3))
            {
                foobarDict.Add(i, "foo");
            }
            else if (checkNumber.IsDivisibleBy(5))
            {
                foobarDict.Add(i, "bar");
            }
        }

        // Mengakses nilai deret dan mencetak hasilnya
        foreach (KeyValuePair<int, string> pair in foobarDict)
        {
            Console.WriteLine(pai);
        }
    }
}

class CheckNumber
{
    private int number;

    public CheckNumber(int number)
    {
        this.number = number;
    }

    public bool IsDivisibleBy(int divisor)
    {
        return number % divisor == 0;
    }
}
