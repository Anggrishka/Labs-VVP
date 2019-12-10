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

            int sum = 1000, k = 0;
            Console.Write(" P = ");
            int P = Convert.ToInt32(Console.ReadLine());

            while (sum <= 1100)
            {
            sum= sum + (sum * P) / 100;
            k = k + 1;
            }
            

            Console.WriteLine(" k = " + k);
            Console.WriteLine(" sum = " + sum);
            Console.ReadLine();
        }
    }
}
