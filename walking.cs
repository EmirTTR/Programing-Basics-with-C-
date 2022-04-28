using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            int steps = 0;
            while (steps<goal)
            {
                string input = Console.ReadLine();
                if (input=="Going home")
                {
                    int left = int.Parse(Console.ReadLine());
                    steps+=left;
                    break;
                }
                int currentSteps = int.Parse(input);
                steps+=currentSteps;
            }
            if (steps>goal)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{steps-goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal-steps} more steps to reach goal.");
            }
        }
    }
}
