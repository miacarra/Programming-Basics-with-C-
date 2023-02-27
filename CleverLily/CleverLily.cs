using System;

namespace CleverLily
{
    class CleverLily
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double money = 0;
            int toys = 0;
            int moneySize = 0;
            double soldToysProfit = 0;
            double savings = 0;
            double washingMashineCosts = double.Parse(Console.ReadLine());
            double toyPrise = double.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 != 0)
                {
                    toys++;
                }
                if (i % 2 == 0)
                {
                    moneySize += 10;
                    money += moneySize - 1;

                }
            }
            soldToysProfit = toys * toyPrise;
            savings = money + soldToysProfit;

            if (savings >= washingMashineCosts)
            {
                Console.WriteLine($"Yes! {(savings - washingMashineCosts):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(savings - washingMashineCosts):f2}");
            }
        }
    }
}
