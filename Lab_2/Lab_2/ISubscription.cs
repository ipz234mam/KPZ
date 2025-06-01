using System.Collections.Generic;

public interface ISubscription
{
    string Name { get; }
    double MonthlyFee { get; }
    int MinPeriodMonths { get; }
    List<string> Channels { get; }
    List<string> Features { get; }
    void DisplayInfo();
}
