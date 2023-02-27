using System;
namespace Coins
{
    class Coins
    {
        static void Main()
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            int coins = 0;
            decimal twoBgnCoin = 2M;
            decimal oneBgnCoin = 1M;
            decimal fiftySt = 0.5M;
            decimal twentySt = 0.2M;
            decimal tenSt = 0.1M;
            decimal fiveSt = 0.05M;
            decimal twoSt = 0.02M;
            decimal oneSt = 0.01M;

            while (sum != 0)
            {
                if (sum >= twoBgnCoin)
                {
                    coins++;
                    sum-= twoBgnCoin;

                }
                if (sum >= oneBgnCoin&&sum<twoBgnCoin)
                {
                    coins++;
                    sum -=  oneBgnCoin;

                }
                if (sum >= fiftySt&&sum<oneBgnCoin)
                {
                    coins++;
                    sum -=fiftySt;

                }
                if (sum>=twentySt&&sum<fiftySt)
                {
                    coins++;
                    sum -= twentySt;

                }
                if(sum>=tenSt&&sum<twentySt)
                {
                    coins++;
                    sum -= tenSt;

                }
                if(sum>=fiveSt&&sum<tenSt)
                {
                    coins++;
                    sum -=fiveSt;

                }
                if (sum>=twoSt&&sum<fiveSt)
                {
                    coins++;
                    sum -= twoSt;

                }
                if (sum>=oneSt&&sum<twoSt)
                {
                    coins++;
                    sum -= oneSt;

                }
            }
            Console.WriteLine(coins);
        
        
        }
    }
}
