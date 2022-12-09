using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task3SecondMax
{
    class Program
    {
        static void Main(string[] args)
        {            
            int max1 = 0;
            int max2 = 0;
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max2 = num;
                }
            }
            while (num != 0);
            Console.WriteLine(max2);
        }
    }
}
