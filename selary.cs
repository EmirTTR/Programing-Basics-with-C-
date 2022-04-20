using System;

namespace Selary
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOpenTabs = int.Parse(Console.ReadLine());
            int selary = int.Parse(Console.ReadLine());
        
           const int FACEBOOK = 150;
           const int INSTAGRAM = 100;
           const int REDDIT = 50;
            


            for (int i = 0; i <= countOpenTabs; i++)
            {
                if (selary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                string sites = Console.ReadLine();
                if (sites=="Facebook")
                {
                    selary -= FACEBOOK;
                }
               else if (sites=="Instagram")
                {
                    selary -= INSTAGRAM;
                }
                else if (sites=="Reddit")
                {
                    selary -= REDDIT;
                }
            }
            if (selary>0)
            {
                Console.WriteLine(selary);
            }

        }
    }
}
