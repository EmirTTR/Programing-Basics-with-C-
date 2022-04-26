using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakePeace = cakeWidth * cakeLenght;
            while (cakePeace>0)
            {
                string input = Console.ReadLine();
                if (input=="STOP")
                {
                    break;
                }
                int guestPeaces = int.Parse(input);
                cakePeace -= guestPeaces;

            }
                if (cakePeace>=0)
                {
                   
                    Console.WriteLine($"{cakePeace} pieces are left.");
                }
                else 
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePeace)} pieces more.");
                }
         
       
        }

	
    }
}
