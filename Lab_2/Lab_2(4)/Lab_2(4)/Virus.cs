using System;
using System.Collections.Generic;

public class Virus
{
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string species, double weight, int age)
    {
        Name = name;
        Species = species;
        Weight = weight;
        Age = age;
    }

    // Метод клонування (глибока копія)
    public Virus Clone()
    {
        var clone = new Virus(Name, Species, Weight, Age);

        foreach (var child in Children)
        {
            clone.Children.Add(child.Clone());
        }

        return clone;
    }

    // Метод для виводу інформації про вірус та його дітей
    public void Print(int level = 0)
    {
        string indent = new string(' ', level * 2);
        Console.WriteLine($"{indent}🦠 {Name} ({Species}), {Weight}g, {Age} days");

        foreach (var child in Children)
        {
            child.Print(level + 1);
        }
    }
}
