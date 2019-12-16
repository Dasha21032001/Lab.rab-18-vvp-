using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pr = 1, min=10000000, jmin=0, i=0, j=0;
            Random rand = new Random();
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.Write("Элементы матрицы: ");
            Console.WriteLine();
            for ( i = 0; i < M; i++)
            {
                for ( j = 0; j < N; j++)
                {
                    A[i, j] = rand.Next(100);
                    Console.Write(A[i, j]);
                    if (j != M - 1)
                        Console.Write(" ");
                    else
                        Console.WriteLine();
                }
            }
            j = 0;
            for ( i = 0; i < M; i++)
            {
                i = 0;
                    while (i < M)
                    {
                        pr = pr * A[i, j];
                        i++;
                    }
                
                if (pr < min)
                {
                    min = pr;
                    jmin = j;
                }
                j++;
            }
            Console.WriteLine("Номер столбца с наименьшим произведением элементов: " + jmin);
            Console.WriteLine("Наименьшее произведение элементов столбца: " + pr);
            Console.ReadLine();
        }
    }
}
