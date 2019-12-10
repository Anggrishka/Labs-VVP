using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" x = ");
             int x = Convert.ToInt32(Console.ReadLine());
             Console.Write(" y = ");
             int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                if (y < 0)
                {
                    Console.WriteLine(" 4 четверть ");
                } else { Console.WriteLine(" 1 четверть");  }
            }
            else
            { if (y > 0)
                {
                    Console.WriteLine(" 2 четверть");
                }
                else
                {
                    Console.WriteLine(" 3 четверть");
                }
            }
            Console.ReadLine();
        }
    }
}
