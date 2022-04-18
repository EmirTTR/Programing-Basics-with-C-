using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
           
            int money = 0;
            int neededMoney = 0;
            int toys = 0;
            
            for (int i = 1; i <= lilyAge; i++)
            {
                money += 5;

                if (i%2 == 0)
                {
                    neededMoney += money-1;
                }
                else
                {  
                    toys++;
                }

            }
                   neededMoney+= toys * toyPrice;

            if (neededMoney >= laundryPrice)
            {

                Console.WriteLine($"Yes! {neededMoney - laundryPrice:F2}");
            }
            else
            {

                Console.WriteLine($"No! {laundryPrice - neededMoney:F2}");
            }
            Console.WriteLine(Math.Floor(laundryPrice));
        }
    }
}
