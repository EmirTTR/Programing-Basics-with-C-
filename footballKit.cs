using System;

namespace Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double neededMoneyForBall = double.Parse(Console.ReadLine());
            double shortsPrice = shirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double shoes = (2 * shirtPrice) + (2 * shortsPrice);
           double needed = shirtPrice + socksPrice + shortsPrice + shoes;
            double moneyOff = needed * 15 / 100;
            needed -= moneyOff;


            if (needed>=neededMoneyForBall)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {needed:f2} lv.");

            }
            else
            {
                double dont = neededMoneyForBall-needed;
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {dont:f2} lv. more.");
            }




        }
    }
}
