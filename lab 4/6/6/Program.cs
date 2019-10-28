using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, A2, B1, B2, C1, C2, y, x;

            Console.WriteLine("Введите А1 и А2");
            A1 = Convert.ToDouble(Console.ReadLine());
            A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите В1 и В2");
            B1 = Convert.ToDouble(Console.ReadLine());
            B2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите С1 и С2");
            C1 = Convert.ToDouble(Console.ReadLine());
            C2 = Convert.ToDouble(Console.ReadLine());

            y = (A1 * C2 - A2 * C1) / (A1 * B2 - A2 * B1);
            x = (C1 - B1 * y) / A1;

            Console.WriteLine(" x = " + x);
            Console.WriteLine(" y = " + y);
            Console.ReadLine();
        }
    }
}
