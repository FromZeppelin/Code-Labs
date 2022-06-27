using System;

namespace Lab1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            int Result = 1;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Result *= A[i];
                }
            }
            Console.WriteLine("Произведение элементов массива с чётными номерами: {0}.", Result);
        }
    }
}
