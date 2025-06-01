using System;

public class WebSite : ISubscriptionCreator
{
    public ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("Creating subscription via Website...");
        return SubscriptionFactory(type);
    }

    private ISubscription SubscriptionFactory(string type)
    {
        return type switch
        {
            "Domestic" => new DomesticSubscription(),
            "Educational" => new EducationalSubscription(),
            "Premium" => new PremiumSubscription(),
            _ => throw new ArgumentException("Invalid subscription type")
        };
    }
}
