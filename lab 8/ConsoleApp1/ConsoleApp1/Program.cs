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
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A != B)
            {
                if (A > B)
                {
                    B = A;
                }
                else
                {
                    A = B;
                }
            } else
            {
                A = 0;
                B = 0;
            }

            Console.WriteLine(" A = " + A);
            Console.WriteLine(" B = " + B);

            Console.ReadLine();

        }
    }
}
