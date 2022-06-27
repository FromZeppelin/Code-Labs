using System;

namespace Lab2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество i-ых элементов матрицы: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите количество j-ых элементов матрицы: ");
            int j = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[i, j];
            Console.WriteLine();
            for (i = 0; i < Matrix.GetLength(0); i++)
            {
                for (j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{i + 1}-я строка и {j + 1} столбец: ");
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (i = 0; i < Matrix.GetLength(0); i++)
            {
                for (j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] > 0)
                    {
                        Matrix[i, j] = 1;
                    }
                    else
                    {
                        Matrix[i, j] = 0;
                    }
                }
            }
            for (i = Matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (j = Matrix.GetLength(1) - i - 1; j <= i; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
