using System;

namespace Lab1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int MinValue = A[0], MinIndex = 0;
            for ( int i = 1; i < A.Length; i++)
            {
                if (A[i] < MinValue)
                {
                    MinValue = A[i];
                    MinIndex = i;
                }
            }
            Console.WriteLine("Минимальный элемент массива: {0}.\nПорядковый номер: {1}.", MinValue, MinIndex+1);
        }
    }
}
