using System;
class ClockType
{
    public int Hours;
    public int Minutes;
    public int Seconds;
    public ClockType(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
    }
    public int GetTotalSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }
    public void DisplayTime()
    {
        Console.WriteLine(Hours.ToString("D2") + ":" + Minutes.ToString("D2") + ":" + Seconds.ToString("D2"));
    }
}
class Program
{
    static void Main()
    {
        ClockType c1 = new ClockType(9, 15, 20);
        ClockType c2 = new ClockType(14, 40, 10);
        ClockType c3 = new ClockType(22, 10, 5);
        Console.WriteLine("--- CLOCK ANALYZER STARTED ---");
        Console.Write("Clock 1 -> ");
        c1.DisplayTime();
     int elapsed = c1.GetTotalSeconds();
        Console.WriteLine("Elapsed Seconds: " + elapsed);
        Console.WriteLine("Remaining Seconds: " + (86400 - elapsed));
        Console.Write("Clock 2 -> ");
        c2.DisplayTime();
        int diff = c2.GetTotalSeconds() - c1.GetTotalSeconds();
        if (diff < 0) diff = diff * -1;
     Console.WriteLine("Difference with Clock 1: " + diff + " seconds");
        Console.Write("Clock 3 -> ");
        c3.DisplayTime();
        int remaining = 86400 - c3.GetTotalSeconds();
        Console.WriteLine("Remaining Seconds: " + remaining);
        Console.WriteLine("--- ANALYSIS COMPLETE ---");
    }
}