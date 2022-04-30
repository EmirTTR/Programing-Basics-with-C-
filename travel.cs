using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string go = Console.ReadLine();
            while (go!="End")
            {
                double budget = double.Parse(Console.ReadLine());
                double saved = 0;
                while (saved<budget)
                {

                    saved += double.Parse(Console.ReadLine());
                }
                    Console.WriteLine($"Going to {go}!");
                go = Console.ReadLine();
            }
        }
    }
}
