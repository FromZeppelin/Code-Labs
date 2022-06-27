using System;

namespace Lab3Ex1
{
    internal class Program
    {
        static void QuickSort(int i, int j, int[] r)
        {
            int index = GetPivot(i, j, r);
            if (index != -1)
            {
                int pivot = r[index];
                int k = Partition(i, j, pivot, r);
                QuickSort(i, k - 1, r);
                QuickSort(k, j, r);
            }
        }
        static void GetSort(int[] temp, int[,] Matrix)
        {
            Console.WriteLine("\nБыстрая сортировка столбцов матрицы...\n");

            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                    temp[j] = Matrix[j, i];
                QuickSort(0, temp.Length - 1, temp);
                for (int k = 0; k < Matrix.GetLength(0); k++)
                    Matrix[k, i] = temp[k];
            }
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Console.Write(Matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static int GetPivot(int i, int j, int[] r)
        {
            int FirstKey = r[i];
            for (int k = i + 1; k <= j; k++)
            {
                if (r[k] > FirstKey)
                {
                    return k;
                }
                else if (r[k] < FirstKey)
                {
                    return i;
                }
            }
            return -1;
        }
        static int Partition(int i, int j, int pivot, int[] r)
        {
            int temp;
            int left = i;
            int right = j;
            do
            {
                temp = r[left];
                r[left] = r[right];
                r[right] = temp;
                while (r[left] < pivot)
                {
                    left++;
                }
                while (r[right] >= pivot)
                {
                    right--;
                }
            }
            while (left <= right);
            return left;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int r = n;
            int c = n;
            int[,] Matrix = new int[r, c];
            int[] temp = new int[r];
            Random randomize = new Random();
            Console.WriteLine("\nКвадратная матрица размером {0}x{1}:\n", r, c);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix[i, j] = randomize.Next(-64, 64);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            GetSort(temp, Matrix);
        }
    }
}
