using System;

class Program
{
    static void Main()
    {
        // Ціна ноутбука
        var price = new Money(25000, 50); // 25000 грн 50 коп.

        // Продукт "Ноутбук"
        var laptop = new Product("Ноутбук", "шт", price);

        // Система обліку
        var reporting = new Reporting();

        // Прибуткова накладна
        reporting.RegisterIncome(laptop, 15, DateTime.Now);

        // Звіт
        reporting.InventoryReport();

        // Зниження ціни
        laptop.DecreasePrice(2000, 50);
        Console.WriteLine("\nПісля зниження ціни:");
        laptop.Print();

        // Відвантаження
        reporting.RegisterOutcome("Ноутбук", 5);

        // Звіт повторно
        reporting.InventoryReport();
    }
}
