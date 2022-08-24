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
            Console.WriteLine("Введите числа не превышаюшее по значению 1000, минимум ввести 2 числа, если число закончится на 0, то ввод чисел прекратится");
            int max1 = 0;
            int max2 = 0;
            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num == 0)
                    {
                        break;
                    }
                    else if (num > max1)
                    {
                        max2 = max1;
                        max1 = num;
                    }
                    else if (num > max2)
                    {
                        max2 = num;
                    }

                }
                if (max1 == max2)
                {
                    Console.WriteLine("Вы ввели два одинаковых числа");
                }
                else if (max2 == 0)
                {
                    Console.WriteLine("Необходимо ввести 2 натуральных числа, 0 мы в расчет не берем");
                }
                else
                {
                    Console.WriteLine(max2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
