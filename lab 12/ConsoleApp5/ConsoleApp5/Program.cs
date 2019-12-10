using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static double Fact(int N)
        { int i, s=1;
            
            if ((N % 2) == 0)
            {
                for (i = 2; i < N; i = i + 2)
                {
                   s = i * s;
                }
            } else
            {
                for (i = 1; i < s; i = i + 2)
                {
                   s = i * s;
                }
            }
            return s;
            
        }
        static void Main(string[] args)
        {
           Console.Write(" N = ");
           int N = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Fact(N));
            Console.ReadKey();
            
        }
    }
}
