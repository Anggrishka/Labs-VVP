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
            double a, rad, pi = 3.14;
            Console.WriteLine("Введите рaзмер угла в градусах ");
            a = Convert.ToDouble(Console.ReadLine());

            rad = a * (pi / 180);
            Console.WriteLine("Ваш угол в радианах = " + rad );
            Console.ReadLine();
        }
    }
}
