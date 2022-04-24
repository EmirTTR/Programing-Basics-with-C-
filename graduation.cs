using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grade = 1;
            double finalGradeSum=0;
            int fails = 0;

            while (grade<=12)
            {
                double yearly =double.Parse( Console.ReadLine());

                if (yearly<4.00)
                {

                    fails++;
                    if (fails==2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        break;
                    }
                    continue;
                }
                finalGradeSum += yearly;
                grade++;


            }
                double arr = 0.00;
                  arr  = finalGradeSum / 12;
            if (fails<2)
            {

                    Console.WriteLine($"{studentName} graduated. Average grade: {arr:f2}");
            }
        }
    }
}
