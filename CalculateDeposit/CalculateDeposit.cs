using System;

namespace CalculateDeposit
{
    class CalculateDeposit
    {

        static void Main()
        {

            double depositAmount = Double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double yearlyInterestRate = double.Parse(Console.ReadLine());
            double profit = CalculateDeposit(depositAmount, yearlyInterestRate, period);
            Console.WriteLine(profit);

        }
        public static double CalculateDeposit(double depositAmount, double yearlYinterestRate, int period)

        {
           
            double profit = depositAmount + period * ((depositAmount * (yearlYinterestRate/100) / 12));
            return profit;
        }
    }
}