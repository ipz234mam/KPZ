public interface IDeviceFactory
{
    IDevice CreateLaptop();
    IDevice CreateNetbook();
    IDevice CreateEBook();
    IDevice CreateSmartphone();
}

public class IProneFactory : IDeviceFactory
{
    public IDevice CreateLaptop() => new Laptop("IProne");
    public IDevice CreateNetbook() => new Netbook("IProne");
    public IDevice CreateEBook() => new EBook("IProne");
    public IDevice CreateSmartphone() => new Smartphone("IProne");
}

public class KiaomiFactory : IDeviceFactory
{
    public IDevice CreateLaptop() => new Laptop("Kiaomi");
    public IDevice CreateNetbook() => new Netbook("Kiaomi");
    public IDevice CreateEBook() => new EBook("Kiaomi");
    public IDevice CreateSmartphone() => new Smartphone("Kiaomi");
}

public class BalaxyFactory : IDeviceFactory
{
    public IDevice CreateLaptop() => new Laptop("Balaxy");
    public IDevice CreateNetbook() => new Netbook("Balaxy");
    public IDevice CreateEBook() => new EBook("Balaxy");
    public IDevice CreateSmartphone() => new Smartphone("Balaxy");
}
