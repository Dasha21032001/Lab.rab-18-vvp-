using System;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите значение K (1 <= K <= M): ");
            int[,] A = new int[M, N];
            int K= int.Parse(Console.ReadLine());
            if ( (1<=K) && (K<=M))
            {
                Console.Write("Элементы матрицы: ");
                Console.WriteLine();
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        A[i, j] = rand.Next(100);
                        Console.Write(A[i, j]);
                        if (j != M - 1)
                            Console.Write(" ");
                        else
                            Console.WriteLine();
                    }
                }
                int s = A[K, 0] + A[K, 1] + A[K, 2];
                int pr= A[K, 0] * A[K, 1] * A[K, 2];
                Console.Write("Сумма элементов K-й строки данной матрицы : " +s);
                Console.WriteLine();
                Console.Write("Произведение элементов K-й строки данной матрицы : " + pr);
            }
            else Console.Write("Ошибка при введении значения K!!!!: ");
            Console.ReadLine();
        }
    }
}
    
