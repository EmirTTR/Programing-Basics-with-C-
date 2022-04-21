using System;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightdSum = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                rightdSum += num2;

            }
            if (leftSum==rightdSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int difference = Math.Abs(leftSum - rightdSum);
                Console.WriteLine("No, diff = " + difference);
            }
        }
    }
}
    

