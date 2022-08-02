using System;
using System.Collections.Generic;
using System.Linq;

namespace bubble_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //конструкция try если введут кривые числа
            try
            {
                Console.WriteLine("Введите числа через пробел");
                int buffer;
                string numbers = Console.ReadLine();
                //создаем масив, с помощью метода Split убираем лишние пробелы
                string[] masString = numbers.Split(' ');
                int[] masInt = new int[masString.Length];
                //конвертируем из string в int массив
                masInt = Array.ConvertAll(masString, s => int.Parse(s));
                //сортировка массива
                for (int i = 0; i < masInt.Length - 1; i++)
                {
                    for (int j = i + 1; j < masInt.Length; j++)
                    {
                        if (masInt[i] > masInt[j])
                        {
                            buffer = masInt[i];
                            masInt[i] = masInt[j];
                            masInt[j] = buffer;
                        }
                    }
                }
                Console.WriteLine(string.Join(" ", masInt));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
