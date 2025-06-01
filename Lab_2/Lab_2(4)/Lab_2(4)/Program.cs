using System;

class Program
{
    static void Main()
    {
        // Створення базового віруса (1 покоління)
        var rootVirus = new Virus("Alpha", "Corona", 0.001, 2);

        // Діти (2 покоління)
        var child1 = new Virus("Beta", "Corona", 0.0008, 1);
        var child2 = new Virus("Gamma", "Corona", 0.0009, 1);

        // Внуки (3 покоління)
        var grandchild1 = new Virus("Delta", "Corona", 0.0005, 0);
        var grandchild2 = new Virus("Omicron", "Corona", 0.0006, 0);

        child1.Children.Add(grandchild1);
        child2.Children.Add(grandchild2);

        rootVirus.Children.Add(child1);
        rootVirus.Children.Add(child2);

        // Вивід оригіналу
        Console.WriteLine("🔬 Оригінальний вірус:");
        rootVirus.Print();

        // Клонування
        var clonedVirus = rootVirus.Clone();

        Console.WriteLine("\n🧬 Клонований вірус:");
        clonedVirus.Print();
    }
}
