﻿using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (minNumber > number)
                {
                    minNumber = number;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
