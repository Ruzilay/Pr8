using System;

class Program
{
    static void Main()
    {
        double A = 0, B = 0;
        bool run = true;

        while (run)
        {
            Console.Clear();
            Console.WriteLine("Меню выбора:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("7. Выход");
            Console.Write("Выберите пункт меню: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Введите значение A: ");
                    A = Convert.ToDouble(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Введите значение B: ");
                    B = Convert.ToDouble(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine($"Результат A + B = {A + B}");
                    break;
                case "4":
                    Console.WriteLine($"Результат A - B = {A - B}");
                    break;
                case "5":
                    Console.WriteLine($"Результат A * B = {A * B}");
                    break;
                case "6":
                    if (B != 0)
                    {
                        Console.WriteLine($"Результат A / B = {A / B}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль.");
                    }
                    break;
                case "7":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
