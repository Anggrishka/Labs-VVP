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
            double AB, CA;
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());


            AB = Math.Abs(A + B);
            CA = Math.Abs(C + A);

            if (AB > CA)
            {
                Console.WriteLine(" Наименьшее расстояние CA =" + CA);
            } else if (AB < CA)
            {
                Console.WriteLine(" Наименьшее расстояние AB = " + AB);
            } else
            {
                Console.WriteLine(" Точки расположены на одинаковом расстоянии. " + CA);
            }

            Console.ReadLine();
        }
    }
}
