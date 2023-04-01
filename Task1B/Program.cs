using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводим строку с натуральными числами
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string pattern = @"\d+"; // регулярное выражение для выделения всех натуральных чисел
            MatchCollection matches = Regex.Matches(input, pattern); // выделяем все натуральные числа из строки

            // Формируем массив из найденных чисел
            List<int> numbers = new List<int>();
            foreach (Match match in matches)
            {
                int number = int.Parse(match.Value);
                numbers.Add(number);
            }

            Console.WriteLine("Числа: " + string.Join(", ", numbers));
            Console.WriteLine("Сумма: " + numbers.Sum());
            Console.WriteLine("Максимальное число: " + numbers.Max());
            Console.WriteLine("Порядковый номер максимального числа: " + (numbers.IndexOf(numbers.Max()) + 1));
        }
    }
}
