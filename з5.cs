using System;

namespace з5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, i = 0, j = 0, min = 1000000000, nomer=0, c=0;
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.Write("Элементы матрицы: ");
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(j = 0; j < N; ++j)
            {
                 c = 0;
                for (i = 0; i < M; ++i)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        break;
                    }
                    else
                        c++;
                }
                if (c == M)
                {
                    Console.WriteLine("Номер первого столбца, содержащего только нечётные элементы: " + (i - 1));
                    break;
                }
                else 
                {
                    Console.WriteLine("Столбца, содержащего только нечётные элементы, нет. 0");
                    break;
                }
            }
            
        }
    }
}
