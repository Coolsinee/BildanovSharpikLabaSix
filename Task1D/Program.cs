using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден");
                return;
            }

            string directoryPath = Path.GetDirectoryName(filePath);

            if (directoryPath == null)
            {
                Console.WriteLine("Невозможно определить путь каталога");
                return;
            }

            // Используем регулярное выражение для поиска имен каталогов
            Regex regex = new Regex(@"[A-Za-z]:\\[\w\\\s-]+\\");
            MatchCollection matches = regex.Matches(directoryPath);

            Console.WriteLine("Список каталогов:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.TrimEnd('\\'));
            }
        }
    }
}
