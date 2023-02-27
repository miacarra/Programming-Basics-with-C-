using System;

namespace MagicNumber
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum;
            int combination = 0;
            bool combinationExists = false;
            string message = "";

            for (int i = number; i <= number2; i++)
            {
                for (int j = number; j <= number2; j++)
                {
                    sum = i + j;
                    combination++;
                    if (sum == magicNumber)
                    {
                        combinationExists = true;
                        message = $"Combination N:{combination} ({i} + {j} = {sum})";
                        break;
                    }
                }

                if (combinationExists)
                {
                    break;
                }
            }
            if (combinationExists == false)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
            if (combinationExists == true)
            {
                Console.WriteLine(message);
            }

        }
    }
}
