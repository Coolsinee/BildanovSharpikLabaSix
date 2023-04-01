using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводим 5 строк
            string[] strings = new string[5];
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("Введите строку {0}: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            // Регулярное выражение для поиска и удаления суффикса "ик"
            string pattern = "ик\\b";

            // Обрабатываем каждую строку
            for (int i = 0; i < strings.Length; i++)
            {
                // Удаляем суффикс "ик"
                strings[i] = Regex.Replace(strings[i], pattern, "");
                Console.WriteLine("Результат для строки {0}: {1}", i + 1, strings[i]);
            }
        }
    }
}
