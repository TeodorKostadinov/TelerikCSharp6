using System;

    class NumberOfTrailingZeros
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeroes = 0,swap;
            for (int i = 1; i <= n; i++)
            {
                swap = i;
                while (swap % 5 == 0)
                {
                    
                        zeroes++;
                        swap = swap / 5;
                    
                }
            }
            Console.WriteLine("The number of zeroes is {0}",zeroes);
        }
    }

