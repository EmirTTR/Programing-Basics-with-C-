using System;

namespace new
{
    class Program
{
    static void Main(string[] args)
    {
        string movieName = Console.ReadLine();
        double movieTime = Double.Parse(Console.ReadLine());
        double breakTime = Double.Parse(Console.ReadLine());

        double lunchTime = breakTime * 1.0 / 8;
        double relaxTime = breakTime * 1.0 / 4;

        double freeTime = breakTime - lunchTime - relaxTime;
        double needTime = movieTime - freeTime;

        if (freeTime >= movieTime)
        {
            freeTime = movieTime;
            Console.WriteLine("You have enough time to watch %s and left with %.0f minutes free time.", movieName, needTime);
        }
        if (freeTime < movieTime)
        {
            Console.WriteLine("You don't have enough time to watch %s, you need %.0f more minutes.", movieName, needTime);
        }
    }
}
}
