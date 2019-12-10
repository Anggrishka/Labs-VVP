using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public int PowerA3(int A, int B )
        {
            return B =  A * A * A;
        }

        static void Main(string[] args)
        {
            int B=0;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());

   
            Console.WriteLine("" + PowerA3(A,B));
            Console.ReadLine();
        }
    }
}
