using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string ballance = Console.ReadLine();
            double finalBallance = double.Parse(ballance);

            double sum = 0;


            while (ballance != "NoMoreMoney")
            {
                double money = double.Parse(ballance);
                

                if (money<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                Console.WriteLine($"Increase: {money:f2}");
                sum+=money;
                
                ballance = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2} ");
        }
    }
}
