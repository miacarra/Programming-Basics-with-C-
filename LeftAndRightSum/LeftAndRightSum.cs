using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int numberSequences =int.Parse(Console.ReadLine());
            int sum1= 0;
            int sum2 = 0;
            int input;

            for (int i = 0; i < numberSequences; i++)
            {
                input =int.Parse(Console.ReadLine());
                sum1 += input;
            }
            for (int j = 0; j < numberSequences; j++)
            {
                input = int.Parse(Console.ReadLine());
                sum2 += input;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
