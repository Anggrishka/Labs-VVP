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
            int i, j;
            Console.Write(" N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N];
            Console.Write("Введите числа массива ");

            for (i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < N - 1; i++)
            { for (j = 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        if (i > j)
                        {
                            Console.Write( + j);
                            Console.WriteLine(", " +i);
                        } 
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
