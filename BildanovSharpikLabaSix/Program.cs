using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string pattern = "^abcd2023111111102023$"; // минимальное регулярное выражение для строки "abcd2023111111102023"
            if (Regex.IsMatch(input, pattern))
            {
                string result = input.Replace("2023", "happynewyear"); // заменяем все вхождения "2023" на "happynewyear"
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Введенная строка не соответствует шаблону.");
            }
        }
    }
}
