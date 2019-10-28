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
            double v1, v2, s, S1, t;
            Console.WriteLine(" Введите v1, v2, s, t ");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            s = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());

            S1 = s + t * (v1 + v2);
         
            Console.WriteLine(" расстояние  = " + S1);

            Console.ReadLine();
        }
    }
}