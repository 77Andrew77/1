using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solution_3
{
    internal class Program
    {
        //класс содержащий данные о имени и фамилии
        public class SN
        {
            //имя
            public string Name;
            //фамилия
            public string SurName;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            SN sN = new SN();
            while (true)
            {
                Console.Write("Введите свое имя: ");
                sN.Name = Console.ReadLine();
                //если буквы не являются частью алфавита, то выдаст ошибку
                if (!Regex.IsMatch(sN.Name, "^[A-ZА-ЯЁa-zа-яё]+$"))
                {
                    Console.WriteLine("Имя должно состоять из букв!");
                    continue;
                }
                //если поле пустое, то выдаст ошибку
                else if (sN.Name.Length == 0)
                {
                    Console.WriteLine("Имя не может быть пустым!");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("Введите свою фамилию: ");
                sN.SurName = Console.ReadLine();
                //если буквы не являются частью алфавита, то выдаст ошибку
                if (!Regex.IsMatch(sN.SurName, "^[A-ZА-ЯЁa-zа-яё'+]+$"))
                {
                    Console.WriteLine("Фамилия должна состоять из букв!");
                    continue;
                }
                //если поле пустое, то выдаст ошибку
                else if (sN.SurName.Length == 0)
                {
                    Console.WriteLine("Фамилия не может быть пустой!");
                    continue;
                }
                else
                {
                    break;
                }
            }
            //вывод в формате "фамилия, имя"
            Console.WriteLine($"{sN.SurName}, {sN.Name}");
        }
    }
}
