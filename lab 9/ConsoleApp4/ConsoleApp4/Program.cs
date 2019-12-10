using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, k, s, f;
            string[] a = { "", "сто ","двести ","триста ","четыреста","пятьсот ","шестьсот","семьсот ","восемьсот", "девятьсот"};
            string[] b = { "десять ", "одинадцать ", "двенадцать ", "тринадцать", "четырнадцать ", "пятнадцать", "шестнадцать ", "семнадцать", "восемнадцать","девятнадцать " };
            string[] c = {"", "","двадцать ", "тридцать ", "сорок ", "пятьдесят", "шестьдесят ", "семьдесят", "восемьдесят ", "девяносто" };
            string[] d = { "", "один ", "два ", "три ", "четыре", "пять ", "шесть", "семь ", "восемь", "девять" };

            Console.Write(" Введите  N ");
            int N = Convert.ToInt32(Console.ReadLine());

            k = N / 100;
            Console.Write("" + a[k]);
     
                    if (((N / 10) % 10) == 1)
            {
                m = N % 10;
                Console.Write( " " + b[m]);
            } else
            { s = (N / 10) % 10;
                Console.Write(" " + c[s]);
                f = N % 10;
                Console.Write(" " + d[f]);
            }
            


            Console.ReadLine();
        }
    }
}
