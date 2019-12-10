using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, m ;
            Console.Write(" Введите  ");
             double N = Convert.ToDouble(Console.ReadLine());

            for (i = 0.1; i < 1; i = i + 0.1)
            {
                m = N * i;
                Console.Write("" + i);
                Console.WriteLine("кг = "+ m);
            }

            Console.ReadLine();
        }
    }
}
