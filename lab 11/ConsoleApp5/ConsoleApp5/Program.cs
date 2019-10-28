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

            int s = 0;
            Console.Write(" a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            while ((a != 0) && (b != 0))
            {
                if (a >= b)
                {
                    a = a % b;
                } else {
                    b = b % a;
                }

            }
            s = a + b;

            
            Console.WriteLine(" s = " + s);
            Console.ReadLine();
        }
    }
}
