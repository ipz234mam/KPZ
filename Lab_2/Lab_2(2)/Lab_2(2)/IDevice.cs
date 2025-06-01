public interface IDevice
{
    void ShowInfo();
}

public class Laptop : IDevice
{
    private readonly string _brand;
    public Laptop(string brand) => _brand = brand;
    public void ShowInfo() => Console.WriteLine($"{_brand} Laptop");
}

public class Netbook : IDevice
{
    private readonly string _brand;
    public Netbook(string brand) => _brand = brand;
    public void ShowInfo() => Console.WriteLine($"{_brand} Netbook");
}

public class EBook : IDevice
{
    private readonly string _brand;
    public EBook(string brand) => _brand = brand;
    public void ShowInfo() => Console.WriteLine($"{_brand} EBook");
}

public class Smartphone : IDevice
{
    private readonly string _brand;
    public Smartphone(string brand) => _brand = brand;
    public void ShowInfo() => Console.WriteLine($"{_brand} Smartphone");
}
