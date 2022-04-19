using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
           
            


            for (int i = 0; i < n; i++)
            {

                double num = double.Parse(Console.ReadLine());
                
                if (num < 200)
                {
                    p1++;

                }
               else if (num < 400)
                {
                    p2++;

                }
                else if (num < 600)
                {
                    p3++;

                }
               else if  (num  < 800)
                {
                    p4++;

                }
                else

                {
                    p5++;
                }


            }
           double precentp1 = (double)p1 / n * 100;
           double precentp2 = (double)p2 / n * 100;
           double precentp3 = (double)p3 / n * 100;
           double precentp4 = (double)p4 / n * 100;
           double precentp5 = (double)p5 / n * 100;
            
                Console.WriteLine($"{precentp1:F2}%");
                Console.WriteLine($"{precentp2:F2}%");
                Console.WriteLine($"{precentp3:F2}%");
                Console.WriteLine($"{precentp4:F2}%");
                Console.WriteLine($"{precentp5:F2}%");

           

        }
    }
}