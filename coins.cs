using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double convert = money * 100;
            int cents = (int)convert;
            int coinsCount = 0;
            while (cents>0)
            {
                if (cents-200>=0)
                {
                    coinsCount++;
                    cents -= 200;
                }
                else if (cents-100>=0)
                {
                    coinsCount++;
                    cents -= 100;
                }
                else if (cents-50>=0)
                {
                    coinsCount++;
                    cents -= 50;
                }
                else if (cents-20>=0)
                {
                    coinsCount++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    coinsCount++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    coinsCount++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    coinsCount++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    coinsCount++;
                    cents -= 1;
                }


            }
            Console.WriteLine(coinsCount);
        }
    }
}
