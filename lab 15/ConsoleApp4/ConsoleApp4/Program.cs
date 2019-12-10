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
            int i, min=0,max=0, k1=0, k2=0;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива a ");
            a[0] = int.Parse(Console.ReadLine());
            min = a[0];
            max = a[0];
            for (i = 1; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] < min) { min = a[i]; k1 = i; }
                if (a[i] > max) { max = a[i]; k2 = i; }
            }
            if (k1 > k2)
            {
                for (i = k2 + 1; i < k1 ; i++)
                {
                    a[i] = 0;
                }
            }
            else
            {
                for (i = k1 + 1; i < k2 ; i++)
                {
                    a[i] = 0;
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
