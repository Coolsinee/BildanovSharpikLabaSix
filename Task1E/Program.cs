using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате dd/mm/yyyy:");
            string input = Console.ReadLine();

            // Проверяем соответствие введенной даты заданному формату
            bool isValidDate = Regex.IsMatch(input, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/((16|17|18|19|20)\d{2}|9999)$");

            if (isValidDate)
            {
                Console.WriteLine("Данная строка является датой в формате dd/mm/yyyy");
            }
            else
            {
                Console.WriteLine("Данная строка не является датой в формате dd/mm/yyyy");
            }
        }
    }
}
