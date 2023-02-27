using System;

namespace OldBooks
{
    class OldBooks
    {
        static void Main(string[] args)
       {

            string favoriteBook = Console.ReadLine();
            string input = "";
            int bookCounter = 0;
            do
            {
                input = Console.ReadLine();
                bookCounter++;
                if (input == "No More Books")
                {
                    break;
                }
            } while (input != favoriteBook );
            if (input == favoriteBook)
            {
                Console.WriteLine($"You checked {bookCounter-1} books and found it.");
            }
            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter-1} books.");

            }
        }
    }
}
