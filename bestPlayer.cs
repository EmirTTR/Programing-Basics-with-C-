using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer =Console.ReadLine();
            int score = int.Parse(Console.ReadLine());
            int bestScore = int.MinValue;
            
            while (bestPlayer != "END")
            {
                bestPlayer = Console.ReadLine();
                score = int.Parse(Console.ReadLine());
                if (score > bestScore)
                {
                    bestScore = score;
                    
                }

                if (bestScore >= 10)
                {
                    continue;
                }
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (bestScore >= 3)
            {
                Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestScore} goals.");
            }
        }
    }
}