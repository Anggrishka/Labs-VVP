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
            bool m=false;
            int a, b, c;
            Console.Write(" А = ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write(" последовательность");
            
                a = N / 100;
                b = N / 10 - a*10;
                c = N - b * 10 - a * 100;

                if((a < b)&& (b < c)){
                    m = true;
                    Console.Write(" возрастующая");
                }
                else if ((a > b)&&(b > c)){
                    m = true;
                    Console.Write(" убывающая");
                }
            
            Console.Write(" a = " + m);

            Console.ReadLine();
        }
    }
}
