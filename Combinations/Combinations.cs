using System;

namespace Combinations
{
    class Combinations
    {
        static void Main(string[] args)
        {
            int input =int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0;  i<=input; i++)
            {
                for (int j = 0; j <= input; j++)
                {
                    for (int k = 0; k <= input; k++)

                    {
                        if (i + j + k == input)
                        {
                            result++;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
