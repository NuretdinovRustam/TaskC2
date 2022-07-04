using System;

namespace Task1Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы");
            string num = Console.ReadLine();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i].ToString() == "x")
                {
                    Console.WriteLine("x");
                    break;
                }
                else if (num[i].ToString() == "w")
                {
                    Console.WriteLine("w");
                    break;
                }
            }


        }
    }
}
