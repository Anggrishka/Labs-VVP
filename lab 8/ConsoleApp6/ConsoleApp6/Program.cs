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
            int k=0, m;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            m = N;

            while (m > 0)
            {
                k = k + 1;
                m = m / 10;
            }

            if (k == 1) { Console.Write(" однозначное");
            } else if (k == 2) { Console.Write(" двузначное");
            } else { Console.Write(" трехзначное"); }


            if (N != 0)
            {
                if (N < 0)
                {
                    Console.Write(" отрицательное");
                }
                else
                {
                    Console.Write(" положительное");
                }

                if (N % 2 == 0)
                {
                    Console.Write(" четное");
                }
                else { Console.Write(" нечетное"); }

            } else { Console.Write(" нулевое"); }

            Console.WriteLine(" число");

            Console.ReadLine();
        }
    }
}
