using System;
using System.Collections.Generic;

public class Reporting
{
    private List<WarehouseItem> warehouseItems = new List<WarehouseItem>();

    public void RegisterIncome(Product product, int quantity, DateTime supplyDate)
    {
        var item = warehouseItems.Find(x => x.Product.Name == product.Name);
        if (item != null)
        {
            item.Quantity += quantity;
            item.LastSupplyDate = supplyDate;
        }
        else
        {
            warehouseItems.Add(new WarehouseItem(product, quantity, supplyDate));
        }

        Console.WriteLine($"Поставка: {quantity} {product.Unit} {product.Name} на склад.");
    }

    public void RegisterOutcome(string productName, int quantity)
    {
        var item = warehouseItems.Find(x => x.Product.Name == productName);
        if (item != null && item.Quantity >= quantity)
        {
            item.Quantity -= quantity;
            Console.WriteLine($"Відвантажено: {quantity} {item.Product.Unit} {productName}");
        }
        else
        {
            Console.WriteLine($"Помилка: Недостатньо товару {productName} на складі або не знайдено.");
        }
    }

    public void InventoryReport()
    {
        Console.WriteLine("\n🔍 Звіт по інвентаризації:");
        foreach (var item in warehouseItems)
        {
            item.Print();
            Console.WriteLine();
        }
    }
}
