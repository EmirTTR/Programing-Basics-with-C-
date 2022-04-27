using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failGrades = int.Parse(Console.ReadLine());
            int tryFails = 0;
            int solvedProblems = 0;
            double gradesSum = 0.00;
            string lastProblem = "";
            bool isFailed = true;
            while (tryFails<failGrades)
            {
                string problemName = Console.ReadLine();
                if (problemName=="Enough")
                {
                    isFailed=false;
                    break;
                }
                int grades = int.Parse(Console.ReadLine());
                if (grades<=4)
                {
                    tryFails++;
                }
                gradesSum += grades;
                solvedProblems++;
                lastProblem = problemName;
            }
                
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum/solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: { lastProblem}");
            }
                
                
        }
    }
}
