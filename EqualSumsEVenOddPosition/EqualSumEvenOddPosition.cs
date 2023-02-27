using System;

namespace EqualSumsEVenOddPosition
{
    class EqualSumEvenOddPosition
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            string something;

            for (int i = input1; i <= input2; i++)
            {
                something = i.ToString();
               
                for (int j = 0; j < something.Length; j++)
                {

                    int num = int.Parse(something[j].ToString());

                    if (j % 2 == 0)
                    {
                        sum1 += int.Parse(something[j].ToString());

                    }
                    else
                    {
                        sum2 += int.Parse(something[j].ToString());
                    }
                }

                if (sum1 == sum2)
                {
                    Console.Write(i + " ");
                }
                    sum1 = 0;
                    sum2 = 0;
                

                
             
            }

        }
    }
}

