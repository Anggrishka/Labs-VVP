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
            int i, d;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива ");
            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
             d = a[1] - a[0];
            
            for (i = 2; i < N; i++)
            {
                if (a[i] - a[i - 1] == d)
                {
                    Console.WriteLine(" элемент"+i);
   
                }
            }

            if (i == N )
            {
                Console.WriteLine("Это арифметическая прогрессия");
            }
            else
            {
                Console.WriteLine(" 0 ");
            }

            Console.ReadLine();
        }
    }
}