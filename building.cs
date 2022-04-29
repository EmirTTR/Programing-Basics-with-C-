using System;

namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int roomsByFloor = int.Parse(Console.ReadLine());
                        
            for (int j = nums; j >=1; j--)
            {
                for (int i=0;i<roomsByFloor;i++)
                {
                    if (j==nums)
                    {
                        Console.Write($"L{j}{i} ");
                        continue;
                    }


                    if (j%2==0)
                    {
                        Console.Write($"O{j}{i} ");
                    }


                    else
                    {
                       Console.Write($"A{j}{i} ");
                    }
                    
                }
                        
                Console.WriteLine();
            }
        }
    }
}
