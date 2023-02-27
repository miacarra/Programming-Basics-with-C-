using System;

namespace AccountBallance
{
    class AccountBallance
    {

        static void Main(string[] args)
        {
            string instruction = "NoMoreMoney";
            double installment = 0;
            string input = Console.ReadLine();
            double totalBallance = 0;
            //bool isNumber;
            while (input != instruction)
            {
                if (double.TryParse(input, out installment))
                {

                    if (installment < 0)
                    {
                        Console.WriteLine($"Invalid operation!");
                        break;
                    }
                    else
                    {
                        totalBallance += installment;
                        Console.WriteLine($"Increase: {installment:f2}");
                    }
                }
                else
                {
                    if (input == instruction)
                    {
                        break;
                    }
                    //else
                    //{
                    //    Console.WriteLine($"I do not know what you are");
                    //}
                }
                input = Console.ReadLine();
            }
                Console.WriteLine($"Total: {totalBallance:f2}");
            
        }
    }


}