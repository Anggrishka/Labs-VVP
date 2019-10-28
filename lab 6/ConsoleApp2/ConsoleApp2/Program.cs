using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write(" N =  ");
         
            int  K = Convert.ToInt32(Console.ReadLine());

            a = K % 7;

            Console.Write(" Это ");
            switch (a)
            {
                case 1: Console.WriteLine(" Понедельник 1");
                    break;
                case 2:
                    Console.WriteLine("Вторник 2");
                    break;
                case 3:
                    Console.WriteLine("Среда 3");
                    break;
                case 4:
                    Console.WriteLine("Четверг 4");
                    break;
                case 5:
                    Console.WriteLine("Пятница 5");
                    break;
                case 6:
                    Console.WriteLine("Субота 6");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье 0 ");
                    break;
            }

            
            Console.ReadLine();

        }
    }
}