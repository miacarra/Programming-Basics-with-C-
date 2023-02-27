using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int input = 0;
            int limit = 0; 


            while (limit < sum)
            {
                input =int.Parse(Console.ReadLine());
                limit += input;
                if (limit >= sum)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (limit >= sum)
            {
                Console.WriteLine(limit);
            }
        }
    }
}
    