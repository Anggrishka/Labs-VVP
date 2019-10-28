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
            double A, x, m, y, S;
            Console.WriteLine(" Введите x, A, y");
            x = Convert.ToDouble(Console.ReadLine());
            A = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            m = A / x;
            S = m * y;
            Console.WriteLine(" 1 кг конфет стоит = " + m);
            Console.Write( + y );
            Console.WriteLine(" кг конфет стоит = " + S);

            Console.ReadLine();
        }
    }
}

