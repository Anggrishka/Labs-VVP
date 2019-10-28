using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            
          
            Console.Write(" Введите  направление ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите  точку отправления ");
            char C = Convert.ToChar(Console.ReadLine());

            switch (N)
            {
                case 1:
                    switch (C)
                    {
                        case 'С': Console.WriteLine("З"); break;
                        case 'Ю': Console.WriteLine("В"); break;
                        case 'З': Console.WriteLine("Ю"); break;
                        case 'В': Console.WriteLine("С"); break;
                    }
                    break;
                case -1:
                    switch (C)
                    {
                        case 'С': Console.WriteLine("В"); break;
                        case 'Ю': Console.WriteLine("З"); break;
                        case 'З': Console.WriteLine("С"); break;
                        case 'В': Console.WriteLine("Ю"); break;
                    }
                    break;
                case 0:
                    switch (C)
                    {
                        case 'С': Console.WriteLine("С"); break;
                        case 'Ю': Console.WriteLine("Ю"); break;
                        case 'З': Console.WriteLine("З"); break;
                        case 'В': Console.WriteLine("В"); break;
                    }
                    break;
            }
       
            Console.ReadLine();
        }
    }
}
