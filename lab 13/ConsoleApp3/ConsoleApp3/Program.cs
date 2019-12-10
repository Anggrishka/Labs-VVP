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
            Console.Write(" А = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            a[0] = A;
            a[1] = B;
            a[2] = A + B;
            for (i = 3; i < N; i++)
            {
                a[i] = a[i-1]*2;
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}