using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaNaKvMetar = 7.61;
            double discount = 0.18;
            double broi = double.Parse(Console.ReadLine());
            double kraenRezultat = broi * cenaNaKvMetar;
            double finaldiscount =(kraenRezultat * discount);
            Console.WriteLine("The final price is:"+ (kraenRezultat - finaldiscount) +" lv." );
            Console.WriteLine($"The discount is: {finaldiscount} lv.");
        }
    }
}
