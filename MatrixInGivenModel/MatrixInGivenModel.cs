using System;

    class MatrixInGivenModel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int adder = 0;
            for (int i = 0; i <n; i++)
            {
                adder=i+1;
                for (int k = 0; k < n; k++)
                {
                    mat[i, k] = k+adder ;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(mat[i,k]+"  ");
                }
            Console.WriteLine();
            }
        }
    }

