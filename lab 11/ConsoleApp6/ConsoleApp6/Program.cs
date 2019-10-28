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

            int a=0, b=1, k=1, c;
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (b <= n)
            {
                if (b == n)
                {
                    Console.WriteLine(k+1);
                    break;
                }
                c = a;
                a = b;
                b = c + b;
                k++;
            }
       
            Console.ReadLine();
        }
    }
}