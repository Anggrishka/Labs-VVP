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
            bool m = false;
            int a, b, c, d;
            Console.Write(" А = ");
            int N = Convert.ToInt32(Console.ReadLine());

            a = N % 10;
            b = N / 10 % 10;
            c = N / 100 % 10;
            d = N / 1000;
            if ((a==d)&&(b==c))
            {
                m = true;
            }

            Console.Write(" a = " + m);

            Console.ReadLine();
        }
    }
}
