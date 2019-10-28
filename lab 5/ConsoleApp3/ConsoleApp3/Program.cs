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
            double A, B, m;
            Console.WriteLine(" Введите А и В ");
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            m = A;
            while (m >= B)
            {
                m = m - B;
            }
            Console.WriteLine(" Остаток = " + m);
            Console.ReadLine();
        }
    }
}
