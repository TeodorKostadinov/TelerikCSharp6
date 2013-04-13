using System;

    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int i = 0, j = 0;
            int kj = 0, ki = 0, writer = 1;
            for (; i < (n / 2)+1; i++, j++)
            {
                ki = i;
                kj = j;
                for (; ki < n-i; ki++)
                {
                    arr[ki, kj] = writer;
                    writer++;
                }
                ki--;
                for (kj = kj + 1; kj < n - i;kj++ )
                {
                    arr[ki, kj] = writer;
                    writer++;
                }
                kj--;
                for (ki = n - i - 2; ki >= i; ki--)
                {
                    arr[ki, kj] = writer;
                    writer++;
                } 
                ki++;
                for (kj = n - i - 2; kj >= i + 1; kj--)
                {
                    arr[ki, kj] = writer;
                    writer++;
                }
            }
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write("{0,5}",arr[h,g]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
            
    }

