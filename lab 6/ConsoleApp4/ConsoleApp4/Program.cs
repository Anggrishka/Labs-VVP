using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, S;
            Console.Write(" А =  ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" В = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write(" С = ");
            int C = Convert.ToInt32(Console.ReadLine());

            k = (A / C) * (B / C);
            S = (A*B)-(C * C * k);
            
            Console.WriteLine(" Кол-во квадратов = " + k);
            Console.WriteLine(" Площадь пустой части = " + S);
            Console.ReadLine();

        }
    }
}
