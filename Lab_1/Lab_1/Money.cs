using System;

public class Money
{
    private int whole;
    private int coins;

    public Money(int whole = 0, int coins = 0)
    {
        SetMoney(whole, coins);
    }

    public void SetMoney(int whole, int coins)
    {
        if (coins >= 100)
        {
            this.whole = whole + coins / 100;
            this.coins = coins % 100;
        }
        else
        {
            this.whole = whole;
            this.coins = coins;
        }
    }

    public void Print()
    {
        Console.WriteLine($"{whole} грн {coins:00} коп.");
    }

    public int Whole => whole;
    public int Coins => coins;

    public decimal ToDecimal() => whole + coins / 100.0m;
}
