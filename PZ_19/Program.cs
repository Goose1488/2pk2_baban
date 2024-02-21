using System.Security.Principal;

namespace PZ_19                                 // Работу выполнили Бабан и Печенкин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание объектов
            Bank account0 = new Debit { AccountNumber = "00000",    Holder = "Нулевой",     Balance = 10000 };
            Bank account1 = new Debit { AccountNumber = "11111",    Holder = "Первый",      Balance = 1000 };
            Bank account2 = new Debit { AccountNumber = "22222",    Holder = "Второй",      Balance = 2000 };
            Bank account3 = new Credit { AccountNumber = "33333",   Holder = "Третий",      Balance = 3000 };
            Bank account4 = new Credit { AccountNumber = "44444",   Holder = "Четвертый",   Balance = 1000 };
            Bank account5 = new Accum { AccountNumber = "55555",    Holder = "Пятый",       Balance = 5000 };
            Bank account6 = new Accum { AccountNumber = "66666",    Holder = "Шестой",      Balance = 10000 };
            Bank account7 = new Debit { AccountNumber = "77777",    Holder = "Седьмой",     Balance = 7000 };
            Bank account8 = new Credit { AccountNumber = "88888",   Holder = "Восьмой",     Balance = 8000 };
            Bank account9 = new Accum { AccountNumber = "99999",    Holder = "Девятый",     Balance = 9000 };

            // вывод объектов
            Console.WriteLine($"Номер акаунта: {account0.AccountNumber}, Держатель: {account0.Holder}, Баланс: {account0.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account1.AccountNumber}, Держатель: {account1.Holder}, Баланс: {account1.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account2.AccountNumber}, Держатель: {account2.Holder}, Баланс: {account2.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account3.AccountNumber}, Держатель: {account3.Holder}, Баланс: {account3.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account4.AccountNumber}, Держатель: {account4.Holder}, Баланс: {account4.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account5.AccountNumber}, Держатель: {account5.Holder}, Баланс: {account5.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account6.AccountNumber}, Держатель: {account6.Holder}, Баланс: {account6.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account7.AccountNumber}, Держатель: {account7.Holder}, Баланс: {account7.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account8.AccountNumber}, Держатель: {account8.Holder}, Баланс: {account8.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account9.AccountNumber}, Держатель: {account9.Holder}, Баланс: {account9.Balance} руб.");
            Console.WriteLine("\n\n\n\n");
            // вызов методов
            account0.Deposit(500);
            account1.Withdraw(200);
            Console.WriteLine($"Номер акаунта: {account0.AccountNumber}, Держатель: {account0.Holder}, Баланс: {account0.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account1.AccountNumber}, Держатель: {account1.Holder}, Баланс: {account1.Balance} руб.\n");

            account2.Withdraw(500);
            account2.Deposit(1000);
            Console.WriteLine($"Номер акаунта: {account2.AccountNumber}, Держатель: {account2.Holder}, Баланс: {account2.Balance} руб.\n");

            account5.Deposit(10000);
            account6.WithdrawAfterYears(12, account6.Balance);
            Console.WriteLine($"Номер акаунта: {account5.AccountNumber}, Держатель: {account5.Holder}, Баланс: {account5.Balance} руб.");
            Console.WriteLine($"Номер акаунта: {account6.AccountNumber}, Держатель: {account6.Holder}, Баланс: {account6.Balance} руб.");
        }
    }
}