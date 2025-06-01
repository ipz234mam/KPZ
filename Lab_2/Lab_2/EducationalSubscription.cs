using System;
using System.Collections.Generic;

public class EducationalSubscription : ISubscription
{
    public string Name => "Educational Subscription";
    public double MonthlyFee => 3.49;
    public int MinPeriodMonths => 6;
    public List<string> Channels => new List<string> { "Science", "History", "Documentary" };
    public List<string> Features => new List<string> { "4K Streaming", "2 Devices", "Parental Control" };

    public void DisplayInfo()
    {
        Console.WriteLine($"[{Name}] ${MonthlyFee}/month, Min Period: {MinPeriodMonths} month(s)");
        Console.WriteLine("Channels: " + string.Join(", ", Channels));
        Console.WriteLine("Features: " + string.Join(", ", Features));
    }
}
