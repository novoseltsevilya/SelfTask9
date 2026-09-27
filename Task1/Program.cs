using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.WriteLine("Введите целое число X:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введенное число: {0}.", x);

                Console.WriteLine("Введите целое число Y:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введенное число: {0}.", y);

                Console.WriteLine("Выберите код операции:" +
                            "\n    1 - сложение;" +
                            "\n    2 - вычитание;" +
                            "\n    3 - умножение;" +
                            "\n    4 - деление.");
                int kod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выбранный код операции: {0}.", kod);

                double result = 0;
                switch (kod)
                {
                    case 1:
                        result = x + y;
                        break;
                    case 2:
                        result = x - y;
                        break;
                    case 3:
                        result = x * y;
                        break;
                    case 4:
                        if (y == 0)
                            throw new DivideByZeroException("Деление на ноль невозможно!");
                        result = (double)x / y;
                        break;
                    default:
                        throw new ArgumentException("Введён некорректный код операции.");
                }
                Console.WriteLine("Результат: {0}.", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введено не целое число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка: " + ex.Message);
            }
            Console.WriteLine("Для выхода нажмите любую клавишу:");
            Console.ReadKey();
        }
    }
}