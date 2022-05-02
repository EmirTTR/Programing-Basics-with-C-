using System;

namespace uniquePins
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            for (int one = 2; one <= first; one += 2)
            {
                for (int two = 2; two <= second; two++)
                {
                    for (int three = 2; three <= third; three += 2)
                    {
                        if (two == 2 || two == 3 || two == 5 || two == 7)
                        {
                            Console.WriteLine($"{one} {two} {three}");

                        }
                    }
                }
            }
        }

    }
}