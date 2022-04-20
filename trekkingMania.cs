using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupPeople = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 1; i <= groupPeople; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());

                if (numberOfPeople < 6)
                {
                    musala += numberOfPeople;
                }
                else if (numberOfPeople < 13)
                {
                    monblan += numberOfPeople;
                }
                else if (numberOfPeople < 26)
                {
                    kilimanjaro += numberOfPeople;
                }
                else if (numberOfPeople < 41)
                {
                    k2 += numberOfPeople;
                }
                else

                {
                    everest += numberOfPeople;
                }
            } 
            int totalClimbersCount = musala + monblan + kilimanjaro + k2 + everest;
            double precentmusala = 1.00 * musala / totalClimbersCount * 100;
            double precentmonblan = 1.00 * monblan / totalClimbersCount * 100;
            double precentkilimanjaro = 1.00 * kilimanjaro / totalClimbersCount * 100;
            double precentk2 = 1.00 * k2 / totalClimbersCount * 100;
            double precenteverest = 1.00 * everest / totalClimbersCount * 100;

            Console.WriteLine($"{precentmusala:f2}%");
            Console.WriteLine($"{precentmonblan:f2}%");
            Console.WriteLine($"{precentkilimanjaro:f2}%");
            Console.WriteLine($"{precentk2:f2}%");
            Console.WriteLine($"{precenteverest:f2}%");
        }
    }
}


