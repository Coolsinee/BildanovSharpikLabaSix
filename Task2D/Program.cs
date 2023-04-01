using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[5];

            Console.WriteLine("Введите 5 строк:");
            for (int i = 0; i < 5; i++)
            {
                input[i] = Console.ReadLine();
            }

            string pattern = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
            Regex regex = new Regex(pattern);

            foreach (string str in input)
            {
                if (regex.IsMatch(str))
                {
                    Console.WriteLine("{0} является допустимым идентификатором цвета в HTML", str);
                }
                else
                {
                    Console.WriteLine("{0} не является допустимым идентификатором цвета в HTML", str);
                }
            }
        }
    }
}
