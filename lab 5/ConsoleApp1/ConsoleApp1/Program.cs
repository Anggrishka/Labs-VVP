using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m;
            Console.WriteLine("Размер файла в байтах = ");
            n = Convert.ToDouble(Console.ReadLine());
            m = Math.Round( n/1024 );

                Console.Write(" m = " + m );
            Console.WriteLine(" Кбайт");
            Console.ReadLine();
        }
    }
}
