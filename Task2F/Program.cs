using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод 5 строк с клавиатуры
            string[] lines = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите строку {i + 1}: ");
                lines[i] = Console.ReadLine();
            }
            Regex usdPattern = new Regex(@"\b\d+\.\d+\s+USD\b");
            Regex rurPattern = new Regex(@"\b\d+\s+RUR\b");
            Regex euPattern = new Regex(@"\b\d+\.\d+\s+EU\b");

            // Нахождение всех цен в каждой валюте
            MatchCollection usdMatches = usdPattern.Matches(string.Join(" ", lines));
            MatchCollection rurMatches = rurPattern.Matches(string.Join(" ", lines));
            MatchCollection euMatches = euPattern.Matches(string.Join(" ", lines));

            // Вывод найденных цен по каждой валюте
            Console.WriteLine("Цены в USD:");
            foreach (Match match in usdMatches)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("Цены в RUR:");
            foreach (Match match in rurMatches)
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("Цены в EU:");
            foreach (Match match in euMatches)
            {
                Console.WriteLine(match.Value);
            }
            // Запрос типа целевой валюты и обменного курса
            Console.Write("Введите тип целевой валюты (USD, RUR или EU): ");
            string targetCurrency = Console.ReadLine();

            Console.Write("Введите обменный курс: ");
            double exchangeRate = double.Parse(Console.ReadLine());

            // Инициализация регулярного выражения для замены валюты
            Regex currencyPattern = null;
            switch (targetCurrency)
            {
                case "USD":
                    currencyPattern = usdPattern;
                    break;
                case "RUR":
                    currencyPattern = rurPattern;
                    break;
                case "EU":
                    currencyPattern = euPattern;
                    break;
                default:
                    Console.WriteLine("Некорректный тип целевой валюты");
                    Environment.Exit(1);
                    break;
            }
            // Замена цен на новую валюту с учетом обменного курса
            string replacedText = currencyPattern.Replace(string.Join(" ", lines),
                (m) => (double.Parse(m.Value.Split(' ')[0]) / exchangeRate).ToString("F2") + " " + targetCurrency);

            // Вывод новой строки с ценами в заданной валюте
            Console.WriteLine("Новая строка с ценами в выбранной валюте:");
            Console.WriteLine(replacedText);
        }
    }
}
