using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[5];

            // Вводим 5 строк с клавиатуры
            Console.WriteLine("----------------------------");
            Console.WriteLine("Введите 5 строк:");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < 5; i++)
            {
                strings[i] = Console.ReadLine();
            }

            // Проверяем каждую строку на наличие "cat" в качестве подстроки два раза
            Regex regex = new Regex("cat.*cat");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Строки подходящие условию: ");
            Console.WriteLine("----------------------------");
            foreach (string s in strings)
            {
                if (regex.IsMatch(s))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
