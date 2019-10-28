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
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N != 0)
            {
                if (N < 0)
                {
                    Console.Write(" отрицательное");
                }
                else
                {
                    Console.Write(" Положительное");
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
