using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s=0, i;
            Console.Write(" Введите N  ");
            double N = Convert.ToDouble(Console.ReadLine());

            for(i= 1; i<N; i++)
            {
            s = s + 2 * i - 1;
                Console.WriteLine( "sum now = " + s );
            }

            Console.ReadLine();
        }
    }
}
