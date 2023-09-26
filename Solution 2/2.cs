using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //s = PI * r^2
            Console.Write("Введите радиус круга: ");
            //ввод числа
            string numberString = Console.ReadLine();
            //проверка на ввод числа
            if (double.TryParse(numberString, out double number))
            {
                double s = Math.PI * Math.Pow(number,2);
                Console.WriteLine($"Площадь круга равна {s}");
            }
            //если не число, то вывод о том, что было не число
            else { Console.WriteLine($"Не верный ввод ({numberString}). Введено не число"); Main(args); }
        }
    }
}
