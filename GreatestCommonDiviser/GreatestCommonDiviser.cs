using System;

    class GreatestCommonDiviser
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number ");
            int secondNum = int.Parse(Console.ReadLine());
            while (firstNum != secondNum)
            {
                if (firstNum > secondNum)
                    firstNum = firstNum - secondNum;
                else
                    secondNum = secondNum - firstNum;
            }
            Console.WriteLine("The greatest common diviser is {0}",firstNum);
        }
    }

