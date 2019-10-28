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

            double sum=1, p=1,i;
            Console.Write(" Введите A  ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите N  ");
           double N = Convert.ToDouble(Console.ReadLine());

            for (i = 1; i < N; i++)
            {
                p = p * A;
                sum = sum + p;
            }

            Console.Write(" sum =  " +sum);
            Console.ReadLine();
        }
    }
}
