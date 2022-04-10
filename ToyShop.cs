using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double vacetion = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minnions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int quantity = numPuzzles + dolls+bears+minnions+trucks;


            double pricePuzzels = 2.60;
            double priceDolls = 3.00;
            double priceBears = 4.10;
            double priceMinnions = 8.20;
            double priceTrucks = 2.00;
            
            double poruchka = (numPuzzles * pricePuzzels) + (dolls * priceDolls) + (bears * priceBears) + (minnions * priceMinnions) + (trucks * priceTrucks);
            
            if (quantity >= 50)
            {
                double otstupka= poruchka * 0.25;
                double pechalba = poruchka - otstupka;
                double naema = pechalba * 0.10;
               double obshtotoPari = pechalba - naema;
                
                double ostavashti = obshtotoPari - vacetion;
                Console.WriteLine($"Yes! {ostavashti:F2} lv left.");
            }
            
            else
            {
               double naem = poruchka * 0.10;
               double obshtoPari = poruchka - naem;
                double nedostig = vacetion - obshtoPari;
                 
                Console.WriteLine($"Not enough money! {nedostig:F2} lv needed. ");
            }




        }
    }
}