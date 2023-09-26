using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Напишите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //если больше/равно 18 и меньше 100 то можно получить права
            if (age >= 18 && age<100)
            {
                Console.WriteLine("Вы можете получить водительские права");
            }
            //если меньше 18, то выведеться отказ
            else if(age<18)
            {
                Console.WriteLine("Вам не можете получить водительские права"); Main(args);
            }
            else if(age>=100) { Console.WriteLine("Как то поздно для получения водительских прав");Main(args); }
        }
    }
}
