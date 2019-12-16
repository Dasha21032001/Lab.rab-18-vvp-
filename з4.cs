using System;

namespace з4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, i = 0, j = 0, sum = 0;
            double srarifm = 0;
            Random rand = new Random();
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            int[] B = new int[100];
            Console.Write("Элементы матрицы: ");
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = rand.Next(100);
                    Console.Write(A[i, j]);
                    if (j != M - 1)
                        Console.Write(" ");
                    else
                        Console.WriteLine();
                    B[j] = 0;
                }
            }
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < N; i++)
                {
                    sum = sum + A[i, j];
                    k++;
                }
                srarifm = sum / k;
                k = 0;
                for (i = 0; i < N; i++)
                {
                    if (A[i, j] > srarifm)
                        k++;
                }
                B[j] = k;
            }
            for (i = 0; i < M; i++)
            {
                Console.Write("В " + ( i+1) + " столбце " + B[i]+ " элемент(-ов/-a), больших среднего арифметического всех элементов этого столбца");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
