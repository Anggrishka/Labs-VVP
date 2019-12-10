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
            int C;
            Console.WriteLine(" Введите год");
            int N = Convert.ToInt32(Console.ReadLine());

            C = (N / 100) + 1;
            Console.WriteLine(" Век: " + C );

            Console.ReadLine();
        }
    }
}
