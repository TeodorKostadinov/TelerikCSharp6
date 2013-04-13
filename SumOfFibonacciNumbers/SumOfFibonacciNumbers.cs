using System;

    class SumOfFibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of how many fibonacci numbers? ");
            int n = int.Parse(Console.ReadLine());
            int fibPrev = 0;
            int fibNext = 1;
            int sum =1,swapper;
            for (int i = 0; i < n-2; i++)
            {
                sum = sum + fibNext + fibPrev;
                swapper = fibNext;
                fibNext = fibNext + fibPrev;
                fibPrev = swapper;
            }
            Console.WriteLine("The sum of the first {0} fibonacci numbers is {1}",n,sum);
        }
    }

