
using System;

namespace oneee
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
           
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double sumGrede = 0;
            double avrige = 0;
            double final = 0;
            double percent = 1;

            for (int i = 1; i <= numStudents; i++)
            {
               double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    a++;

                }
                if (grade >= 4 && grade <= 4.99)
                {
                    b++;
                }
                if (grade >= 3 && grade <= 3.99)
                {
                    c++;
                }
                if (grade < 3)
                {
                    d++;
                }
                sumGrede += grade;

                avrige = sumGrede / numStudents;

                
                

            }
            double precentA =   a * numStudents * percent;
            double precentB =   b * numStudents * percent;
            double precentC =   c * numStudents * percent;
            double precentD =   d * numStudents * percent;

            Console.WriteLine($"Top students: {precentA:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {precentB:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {precentC:f2}%");
            Console.WriteLine($"Fail: {precentD:f2}%");
            Console.WriteLine($"Avrige: {avrige:f2}");

            //Ред 1 - 
            //Ред 2 - "Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
            //Ред 3 - "Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
            //Ред 4 - "Fail: {по-малко от 3.00}%"
            //Ред 5 - "Average: {среден успех}"           



        }
    }
}
