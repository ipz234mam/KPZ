using System;

public class ManagerCall : ISubscriptionCreator
{
    public ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("Creating subscription via Manager Call...");
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
