using System;


class DayOfWeek
{
    static void Main(string[] args)
    {
        DateTime now = new DateTime();
        now = DateTime.Now;
        Console.WriteLine(now.DayOfWeek);
    }
}

