using System;

    class CalculateSumWithFactorialAndXOnNth
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x= ");
            int x = int.Parse(Console.ReadLine());
            int s = 1;
            int factor = 1;
            int productOfX = 1;
            for (int i = 1; i <= n; i++)
            {
                factor = factor * i;
                productOfX = productOfX * x;
                s = s + factor / productOfX;
            }
            Console.WriteLine("The sum is {0}",s);
        }
    }

