using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
       static public int sign(int x)
        {

            if (x > 0)
                return x = -1;
            else if (x == 0) return x = 0;
            else return x = 1;

        }

        static void Main(string[] args)
        {
 
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());
           
 
            Console.WriteLine(" " + sign(x) );
            Console.ReadLine();
        }
       
    }
}