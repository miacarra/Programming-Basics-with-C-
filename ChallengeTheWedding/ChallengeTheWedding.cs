using System;

namespace ChallengeTheWedding
{
    class ChallengeTheWedding
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());
           
                for (int i = 1; i <= men; i++)
                {

                    for (int j = 1; j <= women; j++)
                    {
                        Console.Write($"({i} <-> {j}) ");
                        maxTables--;
                        if (maxTables == 0)
                        {
                            break;
                        }

                    }
                    if (maxTables == 0)
                    {
                        break;
                    }

                }
          




        }
    }
}
