using System;

namespace Lab1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] March = new float[30];
            Console.WriteLine("Введите стоимость товаров, проданных фирмой за каждый день марта:\n");
            for (int i = 0; i < March.Length; i++)
            {
                Console.Write($"{i+1}. ");
                March[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("\nВведите среднюю стоимость условной единицы товара, проданного фирмой за один день: ");
            float s = float.Parse(Console.ReadLine());
            float Result = 0;
            for (int i = 0; i < March.Length; i++)
            {
                if (March[i] > s)
                {
                    Result += 1;
                }
            }
            Console.WriteLine("\nКоличество дней, в которые стоимость проданных товаров превысила {0}: {1}.", s, Result);
        }
    }
}
