using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numProject = int.Parse( Console.ReadLine());
            int numHours = numProject * 3;

            Console.WriteLine($"The architect {architectName} will need {numHours} hours to complete {numProject} project/s.");
        }
    }
}
