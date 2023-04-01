using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводим строку с десятичными числами
            Console.WriteLine("Введите строку с десятичными числами:");
            string input = Console.ReadLine();

            // Определяем регулярное выражение для поиска десятичных чисел
            Regex regex = new Regex(@"[-+]?\d+(\.\d+)?");

            // Выделяем все десятичные числа из строки
            MatchCollection matches = regex.Matches(input);

            // Выводим полученный массив десятичных чисел
            Console.WriteLine("Десятичные числа в строке:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            // Заменяем все десятичные числа в строке на слово "number"
            string replaced = regex.Replace(input, "number");

            // Выводим полученную строку с заменой десятичных чисел
            Console.WriteLine("Строка с замененными десятичными числами:");
            Console.WriteLine(replaced);
        }
    }
}
