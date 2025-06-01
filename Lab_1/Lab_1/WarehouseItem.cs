using System;

public class WarehouseItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime LastSupplyDate { get; set; }

    public WarehouseItem(Product product, int quantity, DateTime lastSupplyDate)
    {
        Product = product;
        Quantity = quantity;
        LastSupplyDate = lastSupplyDate;
    }

    public void Print()
    {
        Console.WriteLine($"Товар: {Product.Name}, Кількість: {Quantity} {Product.Unit}, Дата завозу: {LastSupplyDate.ToShortDateString()}");
        Console.Write("Ціна: ");
        Product.Price.Print();
    }
}
