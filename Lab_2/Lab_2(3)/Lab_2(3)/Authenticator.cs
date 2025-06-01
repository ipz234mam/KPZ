using System;

public sealed class Authenticator
{
    private static readonly Lazy<Authenticator> instance = new Lazy<Authenticator>(() => new Authenticator());

    // Приватний конструктор
    private Authenticator()
    {
        Console.WriteLine("🟢 Екземпляр Authenticator створено");
    }

    // Публічне статичне властивість для доступу до екземпляру
    public static Authenticator Instance => instance.Value;

    // Метод для демонстрації
    public void Authenticate(string user)
    {
        Console.WriteLine($"🔐 Користувач '{user}' автентифікований.");
    }
}
