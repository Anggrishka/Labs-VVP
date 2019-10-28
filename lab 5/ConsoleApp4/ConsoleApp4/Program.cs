using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n; 
            Console.WriteLine(" Введите двухзначное число");
            n = Convert.ToInt32(Console.ReadLine());
            a = (n % 10) * 10 + (n / 10);
            Console.WriteLine(" n = " + a );
            Console.ReadLine();
        }
        
    }
}
