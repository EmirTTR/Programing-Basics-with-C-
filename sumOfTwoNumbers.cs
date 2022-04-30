using System;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int sum = i + j;
                    combinations++;
                    if (sum == magic)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magic})");
                        return;
                    }


                }
            }
           
                Console.WriteLine($"{combinations} combinations - neither equals {magic}");
            
        }
    }
}
