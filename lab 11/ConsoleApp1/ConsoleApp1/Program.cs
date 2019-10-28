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

            int i, j;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            for (i = A; i < B+1; i++)
            {
                for (j = 1; j < i+1; j++)
                {
                    Console.Write("" + i);

                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
