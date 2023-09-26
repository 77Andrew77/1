using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solution_1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите любое число: ");
            string n = Console.ReadLine();
            string[] numbers = n.Split(' ');
            
            foreach (string numberString in numbers)
            {
                //попытка преобразования строки в число
                if (double.TryParse(numberString, out double number))
                {
                    //проверка на деление без остатка
                    if ((number % 2) == 0)
                    {
                        Console.WriteLine($"{number} - Четное");
                    }
                    else if ((number % 2) != 0)
                    {
                        Console.WriteLine($"{number} - Не четное");
                    }
                }
                //если не число, то выдаст ошибку
                else { Console.WriteLine($"Не верный ввод ({numberString}). Число либо не целое, либо введен"); }
            }
            Console.ReadKey();
        }
    }
}