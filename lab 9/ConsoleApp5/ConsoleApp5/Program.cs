using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, k, f;
            string[] a = { "крысы", "коровы", "тигра", "зайца", "дракона", "змеи", "лошади", "овцы", "обезьяны", "курицы", "собаки", "свиньи" };
            string[] b = { "бел", "бел", "черн", "черн", "зелен", "зелен", "красн", "красн", "желт","желт" };
            Console.Write(" Введите год ");
            int N = Convert.ToInt32(Console.ReadLine());

            f = N % 10;
            Console.Write("" +b[f]);


            m = N % 12;
            if ((m>6)&&(m<8)) {
                Console.Write("ого");
            }
            else { Console.Write("ой"); }

            k = ((N + 8) % 12);
            Console.Write(" " +a[k]);


            Console.ReadLine();
        }
    }
}
