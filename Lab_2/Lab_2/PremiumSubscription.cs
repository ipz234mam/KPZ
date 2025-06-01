using System;
using System.Collections.Generic;

public class PremiumSubscription : ISubscription
{
    public string Name => "Premium Subscription";
    public double MonthlyFee => 12.99;
    public int MinPeriodMonths => 3;
    public List<string> Channels => new List<string> { "All Channels" };
    public List<string> Features => new List<string> { "4K Streaming", "Unlimited Devices", "Offline Mode", "No Ads" };

    public void DisplayInfo()
    {
        Console.WriteLine($"[{Name}] ${MonthlyFee}/month, Min Period: {MinPeriodMonths} month(s)");
        Console.WriteLine("Channels: " + string.Join(", ", Channels));
        Console.WriteLine("Features: " + string.Join(", ", Features));
    }
}
