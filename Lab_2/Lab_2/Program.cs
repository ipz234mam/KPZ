using System;

public class Program
{
    public static void Main()
    {
        ISubscriptionCreator website = new WebSite();
        ISubscriptionCreator app = new MobileApp();
        ISubscriptionCreator call = new ManagerCall();

        var sub1 = website.CreateSubscription("Domestic");
        sub1.DisplayInfo();
        Console.WriteLine();

        var sub2 = app.CreateSubscription("Educational");
        sub2.DisplayInfo();
        Console.WriteLine();

        var sub3 = call.CreateSubscription("Premium");
        sub3.DisplayInfo();
    }
}
