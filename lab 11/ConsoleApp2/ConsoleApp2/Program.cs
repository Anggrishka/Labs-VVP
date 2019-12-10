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

            int i, k=0;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < A+1; i++)
            {
                if ((A > B)||(A==B))
                {
                    k = k + 1;
                   
                    A = A - B;
                   
                }
            }
            Console.WriteLine(" k = " + k);
            Console.ReadLine();
        }
    }
}
