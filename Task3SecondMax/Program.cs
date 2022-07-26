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
            bool cycl = true;
            var num1 = 1;
            var num2 = 0;
            var num3 = 0;
            try
            {
                while (cycl == true)
                {
                    string num = Console.ReadLine();
                    if (num1 > num2 & num3 == 0)
                    {
                        num1 = int.Parse(num);
                        num3 = 1;
                    }
                    else if (num1 > num2 & num2 == 0)
                    {
                        num2 = int.Parse(num);
                    }
                    else if (num1 < num2)
                    {
                        num2 = int.Parse(num);
                    }
                    else if (num == "0")
                    {
                        break;
                    }
                }
                if (num1 < num2)
                {
                    Console.WriteLine(num1);
                }
                else if (num2 < num1)
                {
                    Console.WriteLine(num2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
