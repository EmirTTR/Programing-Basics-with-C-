using System;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            const int needed = 1000;
            int numDays = int.Parse(Console.ReadLine());
            double numKilometers = double.Parse(Console.ReadLine());
            double all = numKilometers;
            
            for (int i = 0; i < numDays; i++)
            {
                double kilometers = double.Parse(Console.ReadLine());
                numKilometers = numKilometers + numKilometers * (kilometers / 100);
                all += numKilometers;
            }

            if (all >= needed)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(all - needed)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(needed - all)} more kilometers");
            }
        }
    }
}