using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write(" Введите день ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите месяц ");
            int b = Convert.ToInt32(Console.ReadLine());

            if ((a > 20) && (a != 30) || (a < 10))
            {
                k = a / 10;
                a = a % 10;
                switch (k)
                {
                    case 2: Console.WriteLine("двадцать"); break;
                    case 3: Console.WriteLine("тридцать"); break;
                }
                switch (a)
                {
                    case 1: Console.WriteLine("первое"); break;
                    case 2: Console.WriteLine("второе"); break;
                    case 3: Console.WriteLine("третье"); break;
                    case 4: Console.WriteLine("четвертое"); break;
                    case 5: Console.WriteLine("пятое"); break;
                    case 6: Console.WriteLine("шестое"); break;
                    case 7: Console.WriteLine("седьмое"); break;
                    case 8: Console.WriteLine("восьмое"); break;
                    case 9: Console.WriteLine("девятое"); break;

                }

            }
            else
            {
                switch (a)
                {
                    case 10: Console.WriteLine("десятое"); break;
                    case 11: Console.WriteLine("одинадцатое"); break;
                    case 12: Console.WriteLine("двенадцатое"); break;
                    case 13: Console.WriteLine("тринадцатое"); break;
                    case 14: Console.WriteLine("четырнадцатое"); break;
                    case 15: Console.WriteLine("пятнадцатое"); break;
                    case 16: Console.WriteLine("шестнадцатое"); break;
                    case 17: Console.WriteLine("семнадцатое"); break;
                    case 18: Console.WriteLine("восьмнадцатое"); break;
                    case 19: Console.WriteLine("девятнадцатое"); break;
                    case 20: Console.WriteLine("двадцатое"); break;
                    case 30: Console.WriteLine("тридцатое"); break;
                }
            }
            switch (b)
            {
                case 1: Console.WriteLine("января"); break;
                case 2: Console.WriteLine("февраля"); break;
                case 3: Console.WriteLine("марта"); break;
                case 4: Console.WriteLine("апреля"); break;
                case 5: Console.WriteLine("мая"); break;
                case 6: Console.WriteLine("июня"); break;
                case 7: Console.WriteLine("июля"); break;
                case 8: Console.WriteLine("августа"); break;
                case 9: Console.WriteLine("сентября"); break;
                case 10: Console.WriteLine("октября"); break;
                case 11: Console.WriteLine("ноября"); break;
                case 12: Console.WriteLine("декабря"); break;
            }

            Console.ReadLine();
        }
    }
}
