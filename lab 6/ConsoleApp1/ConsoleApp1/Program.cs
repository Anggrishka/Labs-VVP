using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write(" N =  ");
            int N = Convert.ToInt32(Console.ReadLine());

            k = N / 60;

            Console.WriteLine(" Полных минут : " + k);
            Console.ReadLine();

        }
    }
}