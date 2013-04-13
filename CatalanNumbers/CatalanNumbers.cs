using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter n= ");
            int n=int.Parse(Console.ReadLine());
            BigInteger upperFactor = 1, downFactor = 1;
            for (int i = n+2; i <=2*n; i++)
            {
                upperFactor = upperFactor * i;
            }
            for (int i = 1; i <=n; i++)
            {
                downFactor = downFactor * i;
            }
            
            Console.WriteLine("The {0}th Catalan number is {1}",n,upperFactor/downFactor);
        }
    }

