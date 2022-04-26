using System;

namespace Any_sBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string aBook = Console.ReadLine();
            int tryCounter = 0;
            string books = Console.ReadLine();
    
            while (books != "No More Books")
            {
                
                
                if (aBook == books)
                {
                    Console.WriteLine($"You checked {tryCounter} books and found it.");
                    break;
                }
                
                tryCounter +=1;
                books = Console.ReadLine();

            }
                if (books=="No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {tryCounter} books.");
                    
                }
            

        }
    }
}
