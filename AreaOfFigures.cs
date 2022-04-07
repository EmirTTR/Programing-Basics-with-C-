using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0.0;
           
            if (figure=="square")
            {
                double side=double.Parse(Console.ReadLine());
                
                result = side * side;
                Console.WriteLine($"{result:F3}");
                

            }
            else if (figure=="rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                result = sideA * sideB;
                Console.WriteLine($"{result:F3}");
                
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                
                result = Math.PI*radius*radius;
                Console.WriteLine($"{result:F3}");
                
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double area = double.Parse(Console.ReadLine());
               
                result = 0.5 * area * side;
                Console.WriteLine($"{result:F3}");




            }
            

        }
    }
}
