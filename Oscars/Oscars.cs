using System;

namespace Oscars
{
    class Oscars
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double totalPoints = double.Parse(Console.ReadLine());
            int numberOfReviewers = int.Parse(Console.ReadLine());
            string reviewer;
            double reviewerPoints;
            double addedPoints = 0;
            for (int i = 0; i < numberOfReviewers; i++)
            {
                reviewer = Console.ReadLine();
                reviewerPoints = double.Parse(Console.ReadLine());
                addedPoints = (reviewer.Length * reviewerPoints) / 2;
                totalPoints += addedPoints;
                if (totalPoints >= 1250.5)
                {
                    break;
                }
            }

            if (totalPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5 - totalPoints):f1} more!");
            }
        } 
    }
}
