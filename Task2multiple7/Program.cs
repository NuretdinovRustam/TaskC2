using System;
using System.Linq;
using System.Collections.Generic;

namespace Task2multiple7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число А, не превышающее 2 x 10^4: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число В, не превышающее 2 x 10^4: ");
            int b = Int32.Parse(Console.ReadLine());
            List<int> NewList = new List<int>();
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                        NewList.Add(i);
                }
                try
                {
                    if (NewList.Last<int>() % 7 == 0 | NewList.Last<int>() == 0)
                        Console.WriteLine(NewList.Last<int>().ToString());
                }
                catch 
                { Console.WriteLine("No"); }
            }
            else
                Console.WriteLine("No");



        }
    }
}
