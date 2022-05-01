using System;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double pakegeWeight = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int moneyForCilometer = int.Parse(Console.ReadLine());
            double all = 0.0;

            if (input=="standard")
            {
                if (pakegeWeight<1)
                {
                    all=moneyForCilometer*0.03;
                }
               else if (pakegeWeight>=1 && pakegeWeight<=10)
                {
                    all = moneyForCilometer * 0.05;
                }
               else if (pakegeWeight>=11 && pakegeWeight<=40)
                {
                    all = moneyForCilometer * 0.10;
                }
               else if (pakegeWeight >= 41 && pakegeWeight <= 90)
                {
                    all = moneyForCilometer * 0.15;
                }
               else if (pakegeWeight >= 91 && pakegeWeight <= 150)
                {
                    all = moneyForCilometer * 0.20;
                }
            }
           if (input=="express")
            {
                if (pakegeWeight < 1)
                {
                    all = moneyForCilometer * (0.03 + (0.03 * 0.8 * pakegeWeight));
                }
                else if (pakegeWeight >= 1 && pakegeWeight <= 10)
                {
                    all = moneyForCilometer * (0.05 + (0.05 * 0.4 * pakegeWeight));
                }
                else if (pakegeWeight >= 11 && pakegeWeight <= 40)
                {
                    all = moneyForCilometer * (0.10 + (0.10 * 0.05 * pakegeWeight));
                }
                else if (pakegeWeight >= 41 && pakegeWeight <= 90)
                {
                    all = moneyForCilometer * (0.15 + (0.15 * 0.02 * pakegeWeight));
                }
                else if (pakegeWeight >= 91 && pakegeWeight <= 150)
                {
                    all = moneyForCilometer * (0.20 + (0.20 * 0.01 * pakegeWeight));
                }
            
            }
            Console.WriteLine($"The delivery of your shipment with weight of {pakegeWeight:f3} kg. would cost {all:f2} lv.");


        }
    }
}
