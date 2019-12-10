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
            double sum  =0 ;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int m = N;
            int[] a = new int[N];
            Console.Write("Введите числа массива ");
            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(" K = ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write(" L = ");
            int L = Convert.ToInt32(Console.ReadLine());

            for (i = K-1; i < L; i++)
            {
                sum = a[i] + sum; 
            }
            Console.WriteLine(" Среднее арифметическое = " + sum);
            K = L-K +1 ;
            sum = sum / K ;
            Console.WriteLine(" Среднее арифметическое = " + sum);

            Console.ReadLine();
        }
    }
}