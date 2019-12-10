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
            bool a1 = false;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" В = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());
            if ((A  <B) && (B < C))
            {
                a1 = true;
            }
            Console.WriteLine(" Выражение A < B < C = " + a1);

            Console.ReadLine();
        }
    }
}