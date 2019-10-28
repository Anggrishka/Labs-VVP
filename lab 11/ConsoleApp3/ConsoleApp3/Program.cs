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

            int  sum = 1, k = 1;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (sum<N)
            {
                k = k + 1;
                sum = k + sum;
            }
 
            Console.WriteLine(" k = " + k);
            Console.WriteLine(" sum = " + sum);
            Console.ReadLine();
        }
    }
}

