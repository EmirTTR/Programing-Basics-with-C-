using System;

namespace SumSecconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPerson = int.Parse(Console.ReadLine());
            int secondPerson = int.Parse(Console.ReadLine());
            int therdPerson = int.Parse(Console.ReadLine());
            int allTime = firstPerson + secondPerson + therdPerson;

            int minutes = 0;
            int seconds = 0;

            if (allTime>=120)
            {
                minutes = 2;
                seconds = allTime - 120;
            }
            else if (allTime>=60)
            {
                minutes = 1;
                seconds = allTime - 60;
            }
            else
            {
                seconds = allTime;
            }
            Console.WriteLine($"{minutes}:{seconds:d2}");
            
          

        }
    }
}
