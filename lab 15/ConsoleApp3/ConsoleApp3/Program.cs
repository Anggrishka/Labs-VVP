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
            int i, res = 0, ar = 0;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива a ");

            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] % 2 != 0)
                {
                    res = a[i];
                }
            }

            for (i = 0; i < N; i++)
            {
                if (a[i] % 2 != 0)
                {
                    a[i] = a[i] + res;
                }
                Console.Write(" " + a[i]);
            }
           

                Console.ReadLine();
        }
    }
}
