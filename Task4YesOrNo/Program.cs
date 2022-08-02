using System;

namespace Task4YesOrNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            string num = Console.ReadLine();
            if (int.TryParse(num, out var parsedNum))
            {
                if (parsedNum == 0)
                {
                    Console.WriteLine("Ввели некорректное значение");
                }
                else
                {
                    int check = Convert.ToInt32(num);
                    if ((!((check % 2) == 0)) | ((check % 2) == 0 & check >= 6 & check <= 20))
                    {
                        Console.WriteLine("YES");
                    }
                    else if (((check % 2) == 0) & ((check >= 2 & check <= 5) | (check > 20)))
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ввели некорректное значение");
            }
        }
    }
}
