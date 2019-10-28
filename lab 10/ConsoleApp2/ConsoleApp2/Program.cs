using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, k=0, pr=1;
            Console.Write(" Введите кол-во элементов  ");
             int N = Convert.ToInt32(Console.ReadLine());
            for(i=1.1; k < N; i = i + 0.1)
            {
                pr = pr * i;
                k = k + 1;
            }

            Console.WriteLine(" произведение = " +pr );
            Console.ReadLine();
        }
    }
}
