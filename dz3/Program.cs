using System;
using System.Linq.Expressions;
using dz3.Enums;
namespace dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("#1");
            int[] number = new int[10];
            Console.WriteLine("введите 10 чисел");
            for (int i = 0; i < 10; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            bool sorted = true;
            for (int i = 1; i < 10; i++)
            {
                if (number[i] <= number[i - 1])
                {
                    Console.WriteLine("последовательность не упорядочена по возрастанию");
                    Console.WriteLine("нарушение: число №" + (i + 1));
                    sorted = false;
                    break;
                }
            }
            if (sorted)
            {
                Console.WriteLine("последовательность упорядочена по возрастанию");
            }
            //2
            try
            {
                Console.WriteLine("#2");
                Console.WriteLine("введите номер карты о 6 до 14");
                var k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 6:
                        Console.WriteLine("шестерка");
                        break;
                    case 7:
                        Console.WriteLine("семерка");
                        break;
                    case 8:
                        Console.WriteLine("восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("девятка");
                        break;
                    case 10:
                        Console.WriteLine("десятка");
                        break;
                    case 11:
                        Console.WriteLine("валет");
                        break;
                    case 12:
                        Console.WriteLine("дама");
                        break;
                    case 13:
                        Console.WriteLine("король");
                        break;
                    case 14:
                        Console.WriteLine("туз");
                        break;
                    default:
                        Console.WriteLine("невено введен номер карты");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("программа завершена");
            }
            //3
            Console.WriteLine("#3");
            Console.WriteLine("введите профессию");
            string profession = Console.ReadLine().ToLower();
            switch (profession)
            {
                case "Jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "Shool Counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "Programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "Bike Gang Mamber":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollors");
                    break;
                case "Rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            //4
            Console.WriteLine("#4");
            Console.WriteLine("введите номер дня недели от 1 до 7");
            int num = int.Parse(Console.ReadLine());
            WeakDay day = (WeakDay)num;
            switch(day)
            {
                case WeakDay.Monday:
                    Console.WriteLine("понедельник");
                    break;
                case WeakDay.Tuesday:
                    Console.WriteLine("вторник");
                    break;
                case WeakDay.Wednesday:
                    Console.WriteLine("среда");
                    break;
                case WeakDay.Thursday:
                    Console.WriteLine("четверг");
                    break;
                case WeakDay.Friday:
                    Console.WriteLine("пятница");
                    break;
                case WeakDay.Saturday:
                    Console.WriteLine("суббота");
                    break;
                case WeakDay.Sunday:
                    Console.WriteLine("воскресенье");
                    break;
            }
            //5
            Console.WriteLine("#5");
            string[] doll =
            {
                "Hello Kitty", "Barbie doll", "кукла лол","Hello Kitty", "винкс"
            };
            int count = 0;
            foreach (string dolls in doll)
            {
                if(dolls == "Hello Kitty"|| dolls == "Barbie doll")
                {
                    count ++;
                }
            }
            Console.WriteLine("количество кукол в сумке:" + count);
        }
    }
}
