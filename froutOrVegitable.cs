using System;

namespace FruitorVegitable
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string v = word;

            switch (word)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":

                    Console.WriteLine("fruit");
                        break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    
                    break;
            }

        }
    }

}
    

