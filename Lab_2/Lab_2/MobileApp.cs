using System;

public class MobileApp : ISubscriptionCreator
{
    public ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("Creating subscription via Mobile App...");
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
