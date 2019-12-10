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
            int i, k=1;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            //IncreaseLength(ref a, 22);

            for (i = 0; i < N; i++)
            {
                a[i] = k;
                k = k + 2;
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
