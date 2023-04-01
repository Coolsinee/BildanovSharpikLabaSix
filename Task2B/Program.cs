using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2B
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

            // Регулярное выражение для поиска слов длиной 10 и более символов
            Regex regex = new Regex(@"\b\w{10,}\b");

            Console.WriteLine("Строки с заменой на '*':");
            foreach (string str in strings)
            {
                string result = regex.Replace(str, "*"); // Замена на символ "*"
                Console.WriteLine(result);
            }

            Console.WriteLine("Строки с заменой на первую букву:");
            foreach (string str in strings)
            {
                string result = regex.Replace(str, match => match.Value[0].ToString()); // Замена на первую букву
                Console.WriteLine(result);
            }

            Console.WriteLine("Строки с заменой на первые буквы:");
            foreach (string str in strings)
            {
                string result = regex.Replace(str, match => match.Value.Substring(0, match.Length)); // Замена на первые буквы
                Console.WriteLine(result);
            }
        }
    }
}
