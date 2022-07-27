using System;

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
                int x = b - a;
                int max = 25;
                if (!(a <= b) | (Math.Abs(a) > 2 * (Math.Pow(10, 4))) | (Math.Abs(b) > 2 * (Math.Pow(10, 4))))
                {
                    Console.WriteLine("Значение не удовлетворяет условию");
                }
                else if (Math.Abs(x) < 7)
                {
                    Console.WriteLine("No");
                }
                else if (Math.Abs(x) >= 7)
                {
                    //var max = 1;
                    for (int i = a; i <= b; i++)
                    {
                        if (i % 7 == 0)
                        {
                            max = i;
                        }
                    }
                    Console.WriteLine(max);
                }
            }
            catch
            {
                Console.WriteLine("Ввели некорректное число");
            }
        }
    }
}
