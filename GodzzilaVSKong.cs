using System;

namespace GodzzilavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numStatists = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double decore = movieBudget * 0.1;
            double totalpriceforClothes = numStatists * clothesPrice;

            if (numStatists > 150)
            {
                totalpriceforClothes = totalpriceforClothes * 0.90;
            }
            double totalMoney = decore + totalpriceforClothes;

            if (totalMoney>movieBudget)
            {
                double nedostig = totalMoney - movieBudget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {nedostig:f2} leva more."); 
            }
            else 
            {
                double poveche = movieBudget - totalMoney;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {poveche:f2} leva left.");

            }
        
        }
    }
}
