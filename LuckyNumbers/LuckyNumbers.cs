using System;

namespace LuckyNumbers
{
    class LuckyNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input <= 9)
            {
                for (int num1 = 1; num1 <= input; num1++)
                {
                    for (int num2 = 1; num2 <= input; num2++)
                    {
                        for (int num3 = 1; num3 <= input; num3++)
                        {
                            for (int num4 = 1; num4 <= input; num4++)
                            {
                                if ((num1 + num2) == (num3 + num4) && (input % (num3 + num4)) == 0)
                                {
                                    Console.Write($"{num1}{num2}{num3}{num4} ");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }

                    }
                }

            }

            else
            {
                for (int num1 = 1; num1 <= 9; num1++)
                {
                    for (int num2 = 1; num2 <= 9; num2++)
                    {
                        for (int num3 = 1; num3 <= 9; num3++)
                        {
                            for (int num4 = 1; num4 <= 9; num4++)
                            {
                                if ((num1 + num2) == (num3 + num4) && (input % (num3 + num4)) == 0)
                                {
                                    Console.Write($"{num1}{num2}{num3}{num4} ");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }

                    }
                }


            }

        }
    }
}
