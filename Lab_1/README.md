# Лабораторна робота: Склад товарів

## Принципи програмування, які були реалізовані

### 1. DRY (Don't Repeat Yourself)
Уникаємо повторення логіки. Наприклад, метод `SetMoney` використовується для встановлення значення грошей, і не дублюється в інших частинах програми.
- [Money.cs:10–22](https://github.com/ipz234mam/KPZ/blob/main/Money.cs#L10-L22)

### 2. KISS (Keep It Simple, Stupid)
Код реалізований просто і зрозуміло. Наприклад, метод `RegisterOutcome` обробляє лише необхідну логіку.
- [Reporting.cs:17–26](https://github.com/ipz234mam/KPZ/blob/main/Reporting.cs#L17-L26)

### 3. SRP (Single Responsibility Principle)
Кожен клас має лише одну відповідальність:
- `Money` — обробка грошових одиниць.
- `Product` — опис продукту.
- `WarehouseItem` — одиниця зберігання на складі.
- `Reporting` — логіка обліку.
- [Product.cs](https://github.com/ipz234mam/KPZ/blob/main/Product.cs)
- [Reporting.cs](https://github.com/ipz234mam/KPZ/blob/main/Reporting.cs)

### 4. OCP (Open/Closed Principle)
Клас `Product` можна розширити (наприклад, додати податкову ставку), не змінюючи існуючий код.
- [Product.cs](https://github.com/ipz234mam/KPZ/blob/main/Product.cs)

### 5. LSP (Liskov Substitution Principle)
Ми не реалізовуємо наслідування, однак класи спроєктовані так, що їх можна розширити без порушення логіки (наприклад, `Money` може бути базовим класом для валюти).

### 6. ISP (Interface Segregation Principle)
Інтерфейси тут не використовуються, однак класи розділені так, що не нав’язують зайвих методів.

### 7. DIP (Dependency Inversion Principle)
Клас `Reporting` працює з абстракціями `Product`, а не з їх внутрішніми реалізаціями.

### 8. YAGNI (You Ain't Gonna Need It)
Уникаємо додавання зайвої логіки — наприклад, у `Product` немає логіки, яка зараз не використовується.

### 9. Composition Over Inheritance
Ми використовуємо композицію — наприклад, `WarehouseItem` включає `Product`, замість успадкування.
- [WarehouseItem.cs:6](https://github.com/ipz234mam/KPZ/blob/main/WarehouseItem.cs#L6)

### 10. Fail Fast
У методі `RegisterOutcome` одразу перевіряємо кількість і виводимо помилку, якщо її недостатньо.
- [Reporting.cs:19–22](https://github.com/ipz234mam/KPZ/blob/main/Reporting.cs#L19-L22)

---

## Запуск
```bash
dotnet run
```

## Автор
[GitHub профіль](https://github.com/ipz234mam)
