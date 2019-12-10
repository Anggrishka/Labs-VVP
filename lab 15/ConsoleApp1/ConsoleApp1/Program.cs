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
            int i, res;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива a ");

            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int[] b = new int[N];
            Console.Write("Введите числа массива b ");

            for (i = 0; i < N; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < N; i++)
            {
                res = a[i];
                a[i] = b[i];
                b[i] = res;

            }

            Console.WriteLine("массив а");
            for (i = 0; i < N; i++)
            {
                Console.Write(+a[i]);
                Console.Write(", ");
            }

            Console.WriteLine("");
            Console.WriteLine(" массив b");
            for (i = 0; i < N; i++)
            {
                Console.Write(+b[i]);
                Console.Write(", ");
            }

            Console.ReadLine();
        }
    }
}

