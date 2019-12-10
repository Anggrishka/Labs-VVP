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
            bool a1=false;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" В = ");
            int B = Convert.ToInt32(Console.ReadLine());
            if ((A > 2)&&(B <= 3)){
              a1 = true;
            }
            Console.WriteLine(" Выражение = "+a1);

            Console.ReadLine();
        }
    }
}
