using System;

    class DeckOfCards
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 4; k++)
            {
                for (int i = 2; i < 15; i++)
                {
                    switch (i)
                    {
                        case 2: Console.Write("Two"); break;
                        case 3: Console.Write("Three"); break;
                        case 4: Console.Write("Four"); break;
                        case 5: Console.Write("Five"); break;
                        case 6: Console.Write("Six"); break;
                        case 7: Console.Write("Seven"); break;
                        case 8: Console.Write("Eight"); break;
                        case 9: Console.Write("Nine"); break;
                        case 10: Console.Write("Ten"); break;
                        case 11: Console.Write("Jack"); break;
                        case 12: Console.Write("Queen"); break;
                        case 13: Console.Write("King"); break;
                        case 14: Console.Write("Ace"); break;

                        default:
                            break;
                    }
                    switch (k)
                    {
                        case 0: Console.WriteLine(" of hearts"); break;
                        case 1: Console.WriteLine(" of spades"); break;
                        case 2: Console.WriteLine(" of dimonds"); break;
                        case 3: Console.WriteLine(" of clubs");break;
                    }
                }
            }
            
        }
    }

