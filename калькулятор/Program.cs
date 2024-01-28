using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложить два числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы");

                string choice = Console.ReadLine();

                if (choice == "9")
                {
                    break;
                }

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    Console.Write("Введите первое число: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double num2 = double.Parse(Console.ReadLine());

                    if (choice == "1")
                    {
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine($"{num2} - {num1} = {num2 - num1}");
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    }
                    else if (choice == "4")
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль");
                        }
                        else
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                    }
                    else if (choice == "5")
                    {
                        Console.Write("Введите степень: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{num1} ^ {n} = {Math.Pow(num1, n)}");
                    }
                }
                else if (choice == "6" || choice == "7" || choice == "8")
                {
                    Console.Write("Введите число: ");
                    double num = double.Parse(Console.ReadLine());

                    if (choice == "6")
                    {
                        Console.WriteLine($"Квадратный корень из {num} = {Math.Sqrt(num)}");
                    }
                    else if (choice == "7")
                    {
                        Console.WriteLine($"1% от {num} = {num / 100}");
                    }
                    else if (choice == "8")
                    {
                        if (num < 0)
                        {
                            Console.WriteLine("Ошибка: отрицательное число");
                        }
                        else
                        {
                            int fact = 1;
                            for (int i = 2; i <= num; i++)
                            {
                                fact *= i;
                            }
                            Console.WriteLine($"{num}! = {fact}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: неверный ввод");
                }
            }
        }
    }
}
