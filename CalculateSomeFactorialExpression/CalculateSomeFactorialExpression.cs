using System;

    class CalculateSomeFactorialExpression
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the smaller number n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the bigger number k= ");
            int k = int.Parse(Console.ReadLine());
            int kFactor = 1, nFactor = 1;
            for (int i = k-n+1; i <=k; i++)
            {
                kFactor = kFactor * i;
            }
            for (int i = 1; i <= n; i++)
            {
                nFactor = nFactor * i;
            }
            Console.WriteLine("The expression N!*K!/(K-N)! is {0}",nFactor*kFactor);
        }
    }

