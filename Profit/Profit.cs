using System;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int coins1 = int.Parse(Console.ReadLine());
            int coins2 = int.Parse(Console.ReadLine());
            int coins5 = int.Parse(Console.ReadLine());
            int profit = int.Parse(Console.ReadLine());
           
            //int sum = 0;
            
            for (int i = 0; i <= coins1; i++)
            {
                 

                for (int j = 1; j <= coins2; j++)
                {
                

                    for (int k = 1; i <= coins5; k++)
                    {
                        if (i*1 + j*2 + k*5 == profit)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k}*5 lv. = {profit} lv.");
                        }
                    }


                }
                        
                        
               }
            

        }
    }
}
