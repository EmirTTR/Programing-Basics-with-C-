using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quontity = double.Parse(Console.ReadLine());
            double priceByCity = 0.00;

            if (product=="coffee")
                if (city=="Sofia")
                {
                    double coffee = 0.50;
                    priceByCity = coffee * quontity;
                }
                else if (city=="Plovdiv")
                {
                    double coffee = 0.40;
                    priceByCity = coffee * quontity;
                }
                else if (city=="Varna")
                {
                    double coffee = 0.45;
                    priceByCity = coffee * quontity;

                }
                if (product=="water")
                {
                    if (city == "Sofia")
                    {
                        double water = 0.80;
                        priceByCity = water * quontity;
                    }
                    else if (city == "Plovdiv")
                    {
                        double water = 0.70;
                        priceByCity = water * quontity;
                    }
                    else if (city == "Varna")
                    {
                        double water = 0.70;
                        priceByCity = water * quontity;

                    }
                }
                 if (product=="beer")
                {
                    if (city == "Sofia")
                    {
                        double beer = 1.2;
                        priceByCity = beer * quontity;
                    }
                    else if (city == "Plovdiv")
                    {
                        double beer = 1.15;
                        priceByCity = beer * quontity;
                    }
                    else if (city == "Varna")
                    {
                        double beer = 1.10;
                        priceByCity = beer * quontity;

                    }
                }
                 if (product=="sweets")
                {
                    if (city == "Sofia")
                    {
                        double sweets = 1.45;
                        priceByCity = sweets * quontity;
                    }
                    else if (city == "Plovdiv")
                    {
                        double sweets = 1.30;
                        priceByCity = sweets * quontity;
                    }
                    else if (city == "Varna")
                    {
                        double sweets = 1.35;
                        priceByCity = sweets * quontity;

                    }
                }
                 if (product=="peanuts")
                {
                    if (city == "Sofia")
                    {
                        double peanuts = 1.60;
                        priceByCity = peanuts * quontity;
                    }
                    else if (city == "Plovdiv")
                    {
                        double peanuts = 1.50;
                        priceByCity = peanuts * quontity;
                    }
                    else if (city == "Varna")
                    {
                        double peanuts  = 1.55;
                        priceByCity = peanuts * quontity;

                    }
                }
            Console.WriteLine($"{priceByCity}");
            

        }
    }
}
