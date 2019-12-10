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
            int i, res=0, ar=0;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива a ");

            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(" k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < k; i++)
            {
                res = res + a[i];
                ar = res / k;
            }

            int[] b = new int[N];
            for (i = 0; i < k-1; i++)
            {
                b[i] = a[i];
                b[k] = ar;
            }
            for (i = k + 1; i < N; i++)
            {
                b[i] = a[i];
                Console.Write(" " + b[i]);
            }

          

            Console.ReadLine();
        }
    }
}
