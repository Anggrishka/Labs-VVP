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

            for (i = 0; i < N; i++)
            {
                m = m - 1;
                Console.Write(a[i]);
                Console.Write(", ");
                Console.WriteLine(a[m]);
            }
            Console.ReadLine();
        }
    }
}
