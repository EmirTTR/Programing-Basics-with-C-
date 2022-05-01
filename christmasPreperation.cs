using System;

namespace Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            int numRolls = int.Parse(Console.ReadLine());
            int numPlat = int.Parse(Console.ReadLine());
            double numGlue = double.Parse(Console.ReadLine());
            int percentOff = int.Parse(Console.ReadLine());

                double rollsPrice = 5.80;
                double platPrice = 7.20;
                double gluePrice = 1.20;

            double neededMoney = ((double)numRolls * rollsPrice) + ((double)numPlat * platPrice) + (numGlue * gluePrice);
            double finalMoney = neededMoney * percentOff / 100;
            neededMoney -= finalMoney;
            Console.WriteLine($"{neededMoney:f3}");
        }
    }
}
