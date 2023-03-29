using System;
using System.Globalization;
class Program{
    static void Main(){
        //year, month, day
        DateTime dt1 = new DateTime(2022, 12, 1);       // 2022-01-01 00:00:00
        DateTime dt2 = new DateTime(2022, 1, 1, 12, 0, 0);  // 2022-01-01 12:00:00
        DateTime dt3 = new DateTime(2022, 1, 1, 12, 0, 0, 500);  // 2022-01-01 12:00:00.500
        //time right now
        DateTime dt4 = DateTime.Now;  // 2022-01-01 12:00:00.500
        Console.WriteLine(dt1);
        Console.WriteLine(dt2);
        Console.WriteLine(dt3);
        Console.WriteLine(dt4);

        //year, month, day, hour, minute, second, offset dimana offset include coordinate Unversal Time Coordinated (UTC)
        DateTimeOffset dto1 = new DateTimeOffset(2022, 1, 1, 12, 0, 0, TimeSpan.FromHours(1));  // 2022-01-01 12:00:00 +01:00
        DateTimeOffset dto2 = new DateTimeOffset(2022, 1, 1, 12, 0, 0, 500, TimeSpan.FromHours(1));  // 2022-01-01 12:00:00.500 +01:00
        //d, t, m, y, f(for local time), g(for local time), r(for local time
        string str3 = dto1.ToString("D");  // Output: Saturday, January 01, 2022
        string str4 = dto2.ToString("F");  // Output: Saturday, January 01, 2022 12:00:00 PM +01:00

        Console.WriteLine(dto1);
        Console.WriteLine(dto2);
        Console.Write("dto. toString",str3);
        Console.WriteLine(str4);

        DateTime now = DateTime.Now;
        Console.WriteLine(now);         // Output: 2022-01-01 12:00:00
        //mengurangi n hari dari hari sekarang 
        DateTime yesterday = now.AddDays(-1);
        Console.WriteLine(yesterday);  // Output: 2021-12-31 12:00:00

        //menambah n hari dari hari sekarang
        DateTime tomorrow = now.AddDays(1);
        Console.WriteLine(tomorrow);   // Output: 2022-01-02 12:00:00

        string str1 = "01/01/2022";
        string str2 = "12:00:00 PM";

        // Parse the DateTime value using the "MM/dd/yyyy" format membutuhkan using system.Globalization;
        DateTime dt = DateTime.ParseExact(str1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dt);  // Output: 2022-01-01 00:00:00
        // Parse the DateTime value using the "hh:mm:ss tt" format
        dt = DateTime.ParseExact(str2, "hh:mm:ss tt", CultureInfo.InvariantCulture);
        Console.WriteLine(dt);  // Output: tanggal hari ini 12:00:00

        DateTimeOffset local = DateTimeOffset.Now;
        DateTimeOffset utc = local.ToUniversalTime();
        Console.WriteLine (local.Offset); // -06:00:00 (in Central America)
        Console.WriteLine (utc.Offset); // 00:00:00
        //to check if two DateTimeOffset instances represent the same point in time, you can use the Equals method:
        Console.WriteLine (local == utc); // True
        //To include the Offset in the comparison, you must use the EqualsExact method:
        Console.WriteLine (local.EqualsExact (utc)); // False

        TimeZone zone = TimeZone.CurrentTimeZone;
        Console.WriteLine (zone.StandardName); // Pacific Standard Time
        Console.WriteLine (zone.DaylightName); // Pacific Daylight Time
        DaylightTime day = zone.GetDaylightChanges (2019);
        Console.WriteLine (day.Start.ToString ("M")); // 10 March
        Console.WriteLine (day.End.ToString ("M")); // 03 November
        Console.WriteLine (day.Delta); // 01:00:00



    }
}