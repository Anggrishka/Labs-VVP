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

            Console.Write(" Введите номер ");
            int n = Convert.ToInt32(Console.ReadLine());

            int d = n / 10;
            int m = n % 10;

            if (n >= 10 && n <= 20 || n == 20 || n == 30 || n == 40)
            {
                switch (n)
                {
                    case 10:
                        Console.Write("Десять ");
                        break;
                    case 11:
                        Console.Write("Одиннадцать ");
                        break;
                    case 12:
                        Console.Write("Двенадцать ");
                        break;
                    case 13:
                        Console.Write("Тринадцать ");
                        break;
                    case 14:
                        Console.Write("Четырнадцать ");
                        break;
                    case 15:
                        Console.Write("Пятнадцать ");
                        break;
                    case 16:
                        Console.Write("Шестнадцать ");
                        break;
                    case 17:
                        Console.Write("Семнадцать ");
                        break;
                    case 18:
                        Console.Write("Восемнадцать ");
                        break;
                    case 19:
                        Console.Write("Девятнадцать ");
                        break;
                    case 20:
                        Console.Write("Двадцать ");
                        break;
                    case 30:
                        Console.Write("Дридцать ");
                        break;
                    case 40:
                        Console.Write("Сорок ");
                        break;
                }
                Console.Write("учебных заданий");

            }
            else
            {
                switch (d)
                {
                    case 2: Console.Write("Двадцать "); break;
                    case 3: Console.Write("Тридцать "); break;
                    case 4: Console.Write("Сорок "); break;
                }
                switch (m)
                {
                    case 1: Console.Write("одно "); break;
                    case 2: Console.Write("два "); break;
                    case 3: Console.Write("три "); break;
                    case 4: Console.Write("четыре "); break;
                    case 5: Console.Write("пять "); break;
                    case 6: Console.Write("шесть "); break;
                    case 7: Console.Write("семь "); break;
                    case 8: Console.Write("восемь "); break;
                    case 9: Console.Write("девять "); break;
                }
                if (m == 1)
                {
                    Console.Write("учебное задание");
                } else  {
                    Console.Write("учебных заданий");
                }

                Console.ReadLine();
            }
        }
    }
}
