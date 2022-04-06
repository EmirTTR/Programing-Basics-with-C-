using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kuche =int.Parse(Console.ReadLine());
            int Kotka = int.Parse(Console.ReadLine());
            double result = Kuche * 2.50 + Kotka * 4;
            Console.WriteLine($"{result} lv.");






        }
    }
}
