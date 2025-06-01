using System;
using System.Collections.Generic;

public class DomesticSubscription : ISubscription
{
    public string Name => "Domestic Subscription";
    public double MonthlyFee => 5.99;
    public int MinPeriodMonths => 1;
    public List<string> Channels => new List<string> { "News", "Sports", "Entertainment" };
    public List<string> Features => new List<string> { "HD Streaming", "1 Device" };

    public void DisplayInfo()
    {
        Console.WriteLine($"[{Name}] ${MonthlyFee}/month, Min Period: {MinPeriodMonths} month(s)");
        Console.WriteLine("Channels: " + string.Join(", ", Channels));
        Console.WriteLine("Features: " + string.Join(", ", Features));
    }
}
