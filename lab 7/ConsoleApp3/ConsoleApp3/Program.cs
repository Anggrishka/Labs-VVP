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
            bool a=false;
            
            Console.Write(" А = ");
            double N = Convert.ToDouble(Console.ReadLine());
            
            if ((N % 2 == 0)&&( N<99)&&(N>9)){
                a = true;
            }
            Console.WriteLine("" + a);
            Console.ReadLine();
        }
    }
}
