using System;

namespace bubble_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //конструкция try если введут кривые числа
            try
            {
                Console.WriteLine("Сколько чисел планируется вводить?");
                //получаем ответ - это будет длинной массива
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите числа для сортировки:");
                int[] mas = new int[count];
                //заполняем массив int значениями
                for (int i = 0; i < count; i++)
                {
                    mas[i] = int.Parse(Console.ReadLine());
                }
                //сортировка массива, примеры есть на метаните в разделе №2 задача с массивами
                int buffer;
                for (int i = 0; i < count; i++)
                {
                    for (int j = i + 1; j < count; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            buffer = mas[i];
                            mas[i] = mas[j];
                            mas[j] = buffer;
                        }
                    }
                }
                Console.WriteLine("Отсортированные числа");
                foreach (int b in mas)
                {
                    Console.WriteLine(b);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
