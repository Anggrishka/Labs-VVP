using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;
            Console.WriteLine(" Введите число");
            n = Convert.ToInt32(Console.ReadLine());

            a = n % 10;
            b = n / 10;
            c = a * 100 + b;
            Console.WriteLine(" Новое число = " + c );
            Console.ReadLine();
        }
    }
}
