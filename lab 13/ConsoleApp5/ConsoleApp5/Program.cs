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
            int i;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());


            int m = N;
            int[] a = new int[N];
            Console.Write("Введите числа массива ");
            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 1; i < N; i=i+2)
            {
                Console.Write(a[i]);
                Console.Write(", ");           
            }

            Console.WriteLine();

            for (i = ((N - 1)/2) * 2; i>= 0; i=i-2)
            {
                Console.Write(a[i]);
                Console.Write(", ");
            }
           

            Console.ReadLine();
        }
    }
}