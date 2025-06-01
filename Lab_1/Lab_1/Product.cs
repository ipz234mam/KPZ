using System;

public class Product
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public Money Price { get; set; }

    public Product(string name, string unit, Money price)
    {
        Name = name;
        Unit = unit;
        Price = price;
    }

    public void DecreasePrice(int whole, int coins)
    {
        decimal currentPrice = Price.ToDecimal();
        decimal decreaseAmount = whole + coins / 100.0m;
        decimal newPrice = Math.Max(0, currentPrice - decreaseAmount);

        int newWhole = (int)newPrice;
        int newCoins = (int)((newPrice - newWhole) * 100);

        Price.SetMoney(newWhole, newCoins);
    }

    public void Print()
    {
        Console.Write($"{Name} ({Unit}), Ціна: ");
        Price.Print();
    }
}
