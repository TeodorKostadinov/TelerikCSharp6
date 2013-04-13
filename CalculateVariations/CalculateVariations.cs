using System;

    class CalculateVariations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K= ");
            int k = int.Parse(Console.ReadLine());
            int nFactor = 1;
            for (int i = k+1; i <= n; i++)
            {
                nFactor = nFactor * i;
            }
            
            Console.WriteLine("N!/K! is {0}",nFactor);
        }
    }

