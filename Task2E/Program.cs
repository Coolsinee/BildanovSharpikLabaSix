using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[5];
            Console.WriteLine("Введите 5 строк:");
            for (int i = 0; i < 5; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string pattern = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";
            Regex regex = new Regex(pattern);

            foreach (string str in strings)
            {
                if (regex.IsMatch(str))
                {
                    Console.WriteLine($"{str} является GUID");
                }
                else
                {
                    Console.WriteLine($"{str} не является GUID");
                }
            }
        }
    }
}
