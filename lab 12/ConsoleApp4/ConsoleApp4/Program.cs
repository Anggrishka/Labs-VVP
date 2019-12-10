using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
            public static int Quarter(int x, int y)
            {
                int result = 0;

                if (x > 0)
                {
                    if (y > 0)
                        result = 1;
                    else if (y < 0)
                        result = 2;
                }
                else
                {
                    if (y > 0)
                        result = 4;
                    else if (y < 0)
                        result = 3;
                }

                return result;
            }

        

        static void Main(string[] args)
        {
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" четверть " + Quarter(x,y));
          
            Console.ReadLine();
        }

    }
}
