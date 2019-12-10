using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static double RingS(double r1, double r2)
        {
            return Math.PI * (r1 + r2) * (r1 - r2);
        }

        static void Main(string[] args)
        {

            Console.Write(" R1 = ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" R2 = ");
            double r2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(" " + RingS(r1, r2) );
            Console.ReadLine();
        }

    }
}