using System;

class Program{
    static void Main(){
        //hour minute second
        TimeSpan ts1 = new TimeSpan(2, 30, 0);
        Console.WriteLine(ts1); // 2:30:00

        //hanya hour
        TimeSpan ts2 = TimeSpan.FromHours(1);
        Console.WriteLine(ts2); // 1:00:00
        
        // Add the two TimeSpan instances together
        TimeSpan ts3 = ts1.Add(ts2);

        // Calculate the total number of hours represented by the TimeSpan
        double totalHours = ts3.TotalHours;
        double hoursOnly = ts3.Hours;
        double minutesOnly = ts3.Minutes;
        // Print the result to the console
        Console.WriteLine(totalHours);  // Output: 3.5
        Console.WriteLine(hoursOnly);  // Output: 3
        Console.WriteLine(minutesOnly);  // Output: 30
    }
}

