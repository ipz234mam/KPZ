using System;
using System.Collections.Generic;

public class Character
{
    public string Name { get; set; }
    public double Height { get; set; }
    public string BodyType { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothing { get; set; }
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> Actions { get; set; } = new List<string>();

    public void Print()
    {
        Console.WriteLine($"Ім'я: {Name}");
        Console.WriteLine($"Зріст: {Height} м");
        Console.WriteLine($"Статура: {BodyType}");
        Console.WriteLine($"Волосся: {HairColor}");
        Console.WriteLine($"Очі: {EyeColor}");
        Console.WriteLine($"Одяг: {Clothing}");
        Console.WriteLine($"Інвентар: {string.Join(", ", Inventory)}");
        Console.WriteLine($"Дії: {string.Join("; ", Actions)}");
    }
}
