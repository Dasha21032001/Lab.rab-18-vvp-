using System;

namespace лаб.раб__18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите (M) - порядок матрицы(M должно быть нечетным числом!): ");
            int M = int.Parse(Console.ReadLine());
            if (M % 2 == 1)
            {
                int[,] A = new int[M, M];
                Console.Write("Элементы матрицы: ");
                Console.WriteLine();
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        A[i, j] = rand.Next(100);
                        Console.Write(A[i, j]);
                        if (j != M - 1)
                            Console.Write(" ");
                        else
                            Console.WriteLine();
                    }
                }
                Console.Write("Элементы марицы: " + A[2, 0]+" "+ A[2, 1] + " " + A[2, 2] + " " + A[1, 2] + " " + A[0, 2] + " " + A[0, 1] + " " + A[0, 0] + " " + A[1, 0] + " " + A[1, 1] );
            }
            else Console.Write("M чётное. Ошибка в вводе значения порядка матрицы!!! ");
            Console.ReadLine();
        }
    }
}
