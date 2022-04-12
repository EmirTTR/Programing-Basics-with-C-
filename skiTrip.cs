using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
           double price = 0.00;
            double finalPrice = 0.00;
            double final = 0.00;


            switch (room)
            {
                case "room for one person":
                    price = 18.00;
                    break;
                case "apartment":
                    price = 25.00;

                    break;
                case "president apartment":
                    price = 35.00;
                    break;
                default:
                    break;
            }
            days =days-1;
            finalPrice = price * days;
            if (room == "room for one person")
            {
                if (days < 10)
                {
                    finalPrice =  finalPrice + 0;
                }
                if (days >= 10 && days <= 15)
                {
                    finalPrice =  finalPrice + 0;
                }
                if (days > 15)
                {
                    finalPrice = finalPrice + 0;
                }
            }
                if (room== "apartment")
            {
                if (days<10)
                {
                    finalPrice = finalPrice - (finalPrice * 30/100);
                }
                if (days>=10 && days<=15)
                {
                    finalPrice = finalPrice - (finalPrice * 35/100);
                }
                if (days>15)
                {
                    finalPrice = finalPrice - (finalPrice * 50/100);
                }
            }
            if (room == "president apartment")
            {
                if (days < 10)
                {
                    finalPrice = finalPrice - ( finalPrice * 10/100);
                }
                if (days >= 10 && days <= 15)
                {
                    finalPrice = finalPrice - ( finalPrice * 15/100);
                }
                if (days > 15)
                {
                    finalPrice = finalPrice - (finalPrice * 20/100);
                }
            }
            if (rating=="positive")
            {
                final = finalPrice + (finalPrice * 25/100);
            }
           else if (rating=="negative")
            {
                final = finalPrice - (finalPrice * 10/100);
            }
            Console.WriteLine($"{final:F2}");

        }
    }
}
