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
            double A, B, m;
            Console.WriteLine(" Введите А и В ");
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            m = 0;
            while ( A>=B )
            {
                m = m + 1;
                A = A - B;
            }

            Console.WriteLine("Кол-во отрезков В на отрезке А = " + m );
            Console.ReadLine();
        }
    }
}
