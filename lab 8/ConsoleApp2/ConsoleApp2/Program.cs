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
            int S=0;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            if ( A > B)
            {
                if (C > B)
                {
                    S = A + C;
                    
                } else
                {
                    S = A + B;
                }
            } else if (A < B)
            {
                if (C > A)
                {
                    S = B + C;
                } else
                {
                    S = A + B;
                }
            }


            Console.WriteLine(" Sum = " + S);
            Console.ReadLine();

        }
    }
}
