using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, n;
            Console.WriteLine(" Введите А");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите В");
            B = Convert.ToDouble(Console.ReadLine());

            n = -(B/ A);
           
            Console.WriteLine(" x = " + n);

            Console.ReadLine();
        }
    }
}
