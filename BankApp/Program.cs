using System;
using BankLibrary;
using BankLibrary.Bankomat;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000.0; // Начальный баланс счета
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("a. Вывод баланса на экран");
                Console.WriteLine("b. Пополнение счета");
                Console.WriteLine("c. Снять деньги со счета");
                Console.WriteLine("d. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        Console.WriteLine($"Баланс: {balance:C}");
                        break;
                    case "b":
                        Console.Write("Введите сумму для пополнения: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            balance += depositAmount;
                            Console.WriteLine($"Счет пополнен. Новый баланс: {balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма.");
                        }
                        break;
                    case "c":
                        Console.Write("Введите сумму для снятия: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Сумма снята. Новый баланс: {balance:C}");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств на счете.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма.");
                        }
                        break;
                    case "d":
                        exit = true;
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите опцию из меню.");
                        break;
                }
            }
        }
    }
}
