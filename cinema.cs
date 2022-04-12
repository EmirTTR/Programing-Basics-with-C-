using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.00;
            double price = 0.00;
            switch (type)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                default:
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break; 
            }
            income = price * rows * colums;
            Console.WriteLine($"{income:F2}");

        }
    }
}
