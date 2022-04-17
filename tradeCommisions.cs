using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double quontity = double.Parse(Console.ReadLine());
            double sales = 0.00;
            if (city == "Sofia" || city == "Varna" || city=="Plovdiv" && quontity > 0 )
            {

                if (city == "Sofia")
                {


                    if (quontity >= 0 && quontity <= 500)
                    {
                        sales = quontity * 5 / 100;
                    }
                    if (quontity > 500 && quontity <= 1000)
                    {
                        sales = quontity * 7 / 100;
                    }
                    if (quontity > 1000 && quontity <= 10000)
                    {
                        sales = quontity * 8 / 100;
                    }
                    if (quontity > 10000)
                    {
                        sales = quontity * 12 / 100;
                    }
                }
                else
              

                if (city == "Varna")
                {


                    if (quontity >= 0 && quontity <= 500)
                    {
                        sales = quontity * 4.5 / 100;
                    }
                    if (quontity > 500 && quontity <= 1000)
                    {
                        sales = quontity * 7.5 / 100;
                    }
                    if (quontity > 1000 && quontity <= 10000)
                    {
                        sales = quontity * 10 / 100;
                    }
                    if (quontity > 10000)
                    {
                        sales = quontity * 13 / 100;
                    }
                }
                else
            
                if (city == "Plovdiv")
                {


                    if (quontity >= 0 && quontity <= 500)
                    {
                        sales = quontity * 5.5 / 100;
                    }
                    if (quontity > 500 && quontity <= 1000)
                    {
                        sales = quontity * 8 / 100;
                    }
                    if (quontity > 1000 && quontity <= 10000)
                    {
                        sales = quontity * 12 / 100;
                    }
                    if (quontity > 10000)
                    {
                        sales = quontity * 14.5 / 100;
                    }
                    
                }
                Console.WriteLine($"{sales:F2}");

            }
            else
            {
                Console.WriteLine("error");
            }
            






        }
    }
}
