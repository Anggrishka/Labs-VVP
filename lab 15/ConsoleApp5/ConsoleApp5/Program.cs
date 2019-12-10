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
            int i, j,res=0;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива a ");

            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < N - 1; i++)
            {
                for (j = i+1; j < N; j++)
                {
                    if (a[i] > a[j])
                    {
                        res = a[i];
                        a[i] = a[j];
                        a[j] = res;

                    }
                }
            }


            for (i = 0; i < N; i++)
            {
                Console.Write(" " + a[i]);
            }

            Console.ReadLine();
        }
    }
}
