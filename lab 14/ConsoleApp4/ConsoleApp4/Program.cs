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
            int i, el=0;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива ");
            
            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }

            for (i = 1; i < N-1; i++)
            {
                if ((a[i] > a[i + 1]) || (a[i] > a[i - 1]))
                {
                 el = i;
                }

            }
            Console.WriteLine("локальный максимум = " + el);

            Console.ReadLine();
        }
    }
}
