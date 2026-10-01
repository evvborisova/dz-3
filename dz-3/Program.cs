using System;
namespace tumacov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#4.1");
            Console.Write("введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("введите номер дня: ");
            int day = int.Parse(Console.ReadLine());
            int february = 28;
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                february = 29;
            if (day < 1 || day > 365 + (february - 28))
            {
                Console.WriteLine("Ошибка: неправильный номер дня");
            }
            else
            {
                if (day <= 31)
                    Console.WriteLine(day + " января");
                else if (day <= 31 + february)
                    Console.WriteLine(day - 31 + " февраля");
                else if (day <= 62 + february)
                    Console.WriteLine(day - 31 - february + " марта");
                else if (day <= 92 + february)
                    Console.WriteLine(day - 62 - february + " апреля");
                else if (day <= 123 + february)
                    Console.WriteLine(day - 92 - february + " мая");
                else if (day <= 153 + february)
                    Console.WriteLine(day - 123 - february + " июня");
                else if (day <= 184 + february)
                    Console.WriteLine(day - 153 - february + " июля");
                else if (day <= 215 + february)
                    Console.WriteLine(day - 184 - february + " августа");
                else if (day <= 245 + february)
                    Console.WriteLine(day - 215 - february + " сентября");
                else if (day <= 276 + february)
                    Console.WriteLine(day - 245 - february + " октября");
                else if (day <= 306 + february)
                    Console.WriteLine(day - 276 - february + " ноября");
                else
                    Console.WriteLine(day - 306 - february + " декабря");
            }
        }
    }
}