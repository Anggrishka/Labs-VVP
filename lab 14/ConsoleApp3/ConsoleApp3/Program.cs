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
            int i, min;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива ");
            a[0] = int.Parse(Console.ReadLine());
            min = a[0];
            for (i = 1; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (a[i] <= min)
                    {
                        min = a[i];
                    }
                }
            }
            Console.WriteLine("min = " +min);

            Console.ReadLine();
        }
    }
}