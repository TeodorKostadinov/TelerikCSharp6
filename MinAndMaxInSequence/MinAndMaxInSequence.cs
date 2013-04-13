using System;

    class MinAndMaxInSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int minimal,maximum;
            minimal=int.Parse(Console.ReadLine());
            maximum=minimal;
            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if(maximum<arr[i])
                {
                    maximum=arr[i];
                }
                if(minimal>arr[i])
                {
                    minimal=arr[i];
                }
            }
            Console.WriteLine("The minimum is {0} and the maximum is {1}", minimal,maximum);
        }
    }

