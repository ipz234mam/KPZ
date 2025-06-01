using System;

class Program
{
    static void Main()
    {
        TestFactory(new IProneFactory());
        TestFactory(new KiaomiFactory());
        TestFactory(new BalaxyFactory());
    }

    static void TestFactory(IDeviceFactory factory)
    {
        Console.WriteLine("======= " + factory.GetType().Name.Replace("Factory", "") + " Devices =======");
        factory.CreateLaptop().ShowInfo();
        factory.CreateNetbook().ShowInfo();
        factory.CreateEBook().ShowInfo();
        factory.CreateSmartphone().ShowInfo();
        Console.WriteLine();
    }
}
