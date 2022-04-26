using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumNumber = 0;

            while (sumNumber<number)
            {
                int correct = int.Parse(Console.ReadLine());
            
                sumNumber += correct;
               
                
            }
            Console.WriteLine(sumNumber);
            
        }
    }
}
