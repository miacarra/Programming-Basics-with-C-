using System;

namespace for_loops_remind
{
    class MyFavouriteGame
    {
        static void Main(string[] args)
        {
            int countGuesses = 0;
            string magicWord = "Steffie";
            string greeting = "Let's play a game. ";
            string secondGreeting= "You have 3 chances to find my favourite word";
            string thirdGreeting = "Make a  guess :)";
            string prompt= "Last chance :)";
            string proposal = " ";
            Console.WriteLine(greeting);
            Console.WriteLine(secondGreeting);
            Console.WriteLine(thirdGreeting);
            do
            {
                proposal = Console.ReadLine();
                countGuesses++;
                if (proposal == magicWord)
                {
                    break;
                }
                if (countGuesses == 2)
                {
                    Console.WriteLine(prompt);
                }
                if (countGuesses >= 3)
                {
                    Console.WriteLine("Sorry you lost. Want to play again..");
                    break;
                }
            } while (proposal != magicWord);
            Console.WriteLine( "You win!");
            

            
        }
    }
}
