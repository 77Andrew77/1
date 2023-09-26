using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //объявление массива и переменных
            int[] znach = new int[1000];
            int min = znach[0]; int minIndex = 0;
            int max = znach[0]; int maxIndex = 0;
            Console.WriteLine("Введите размер массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("Массив");
            //создание массива
            for (int i = 0; i < x; i++)
            {
                znach[i] = random.Next(-200, 200);
                Console.WriteLine($"{i}: " + znach[i]);
                //присвоение минимального значения и индекса
                if (min > znach[i])
                {
                    min = znach[i];
                    minIndex = i;
                }
                //присвоение максимального значения и индекса
                else if (max < znach[i])
                {
                    max = znach[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine("Максимальное число: " + maxIndex + " = " + max);
            Console.WriteLine("Минимальное число: " + minIndex + " = " + min);
        }
    }
}
