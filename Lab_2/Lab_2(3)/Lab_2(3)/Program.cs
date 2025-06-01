using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Запуск з кількох потоків:\n");

        Parallel.Invoke(
            () => Authenticator.Instance.Authenticate("Anna"),
            () => Authenticator.Instance.Authenticate("Ivan"),
            () => Authenticator.Instance.Authenticate("Oleh")
        );

        Console.WriteLine("\nПеревірка, що екземпляр один і той самий:");
        var auth1 = Authenticator.Instance;
        var auth2 = Authenticator.Instance;
        Console.WriteLine($"auth1 == auth2 ? {ReferenceEquals(auth1, auth2)}"); // Очікується: True
    }
}
