using System;

namespace Lab2Ex2
{
    internal class Program
    {
        static int FindZero(int[,] Matrix)
        {
            int zeropoints = 0; // количество нулей в массиве
            int j = 0;
            int n = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (j = n; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 0)
                    {
                        n += 1; // для проверки всех j-ых элементов на наличие нулей в цикле for
                        zeropoints = j + 1; // подсчет j-ых элементов, содержащих хотя бы один нулевой элемент
                    }
                }
            }
            return zeropoints;
        }
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
            for (i = 0; i < Matrix.GetLength(0); i++)
            {
                for (j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nКоличество столбцов, содержащих хотя бы один нулевой элемент: {0}", FindZero(Matrix));
        }
    }
}
