using System;

namespace TennisRankList
{
    class TennsiRankList
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int intitialPoints = int.Parse(Console.ReadLine());
            double totalPoints = intitialPoints;
            string tournamentType;
            int winnedTournaments = 0;
            double averagePoints = 0;
            double percentageWinnedTournaments = 0;
            for (int i = 0; i < numberOfTournaments; i++)
            {
                tournamentType = Console.ReadLine();
                if (tournamentType == "W")
                {
                    totalPoints += 2000;
                    winnedTournaments += 1;
                }
                if (tournamentType == "F")
                {
                    totalPoints += 1200;

                }
                if (tournamentType == "SF")
                {
                    totalPoints += 720;

                }

            }
            averagePoints = (totalPoints - intitialPoints) / numberOfTournaments;
            percentageWinnedTournaments = (winnedTournaments / (numberOfTournaments * 1.0)) * 100;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Truncate(averagePoints)}");
            Console.WriteLine($"{percentageWinnedTournaments:f2}%");


        }
    }
}
