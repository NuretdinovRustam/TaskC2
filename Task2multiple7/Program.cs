using System;
using System.Collections.Generic;

namespace Task2multiple7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое число А, не превышающее 2 x 10^4: ");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите целое число В, не превышающее 2 x 10^4: ");
                int b = Int32.Parse(Console.ReadLine());
                var NewList = new List<int>();
                if (!(a <= b) | (Math.Abs(a) > 2 * (Math.Pow(10, 4))) | (Math.Abs(b) > 2 * (Math.Pow(10, 4))))
                {
                    Console.WriteLine("Значение не удовлетворяет условию");
                }
                else if (b >= 7)
                {
                    for (int i = a; i <= b; i++)
                    {
                        if (i % 7 == 0)
                        {
                            NewList.Add(i);
                        }
                    }
                    Console.WriteLine(NewList[NewList.Count - 1]);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ввели некорректное число. Ошибка: {ex}");
            }
        }
    }
}
