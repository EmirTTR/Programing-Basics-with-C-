using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jouries = int.Parse(Console.ReadLine());
            double sumPoints = points ;
            
            
            const double finalPoints = 1250.5;

             bool found = false;
            for (int i = 0; i < jouries; i++)
            {
                string jouriesName = Console.ReadLine();
                double juriesPoints = double.Parse(Console.ReadLine());
                points = ((jouriesName.Length * juriesPoints) / 2);
                sumPoints += points;


                if (sumPoints >= finalPoints)
                {
                    found = true;
                    break;


                }
            }
            if (found)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumPoints:f1}!");
            }
            
            else
            {
                double neededPoints = finalPoints - sumPoints;
                Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");
            }
        }
    }
}
