using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney =double.Parse( Console.ReadLine());
            double ownmoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (spendingCounter != 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    ownmoney += money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                   
                    if (money > ownmoney)
                    {
                        ownmoney = 0;
                    }
                    else
                    {
                        ownmoney -= money;
                    } 
                    spendingCounter++;
                }
                
                if (ownmoney>=neededMoney)

                {
                  Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }

                    
            }
            if (spendingCounter==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{daysCounter}");
                    
            }
                

        }
    }
}
