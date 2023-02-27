using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionCosts = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            string input;
            int daysCounter =0;
            double transfer = 0;
            //string lastTransaction="";
            //bool byeVacation = false;
            int badDays = 0;

            do
            {
                input = Console.ReadLine();
                transfer = double.Parse(Console.ReadLine());
                daysCounter++;

                if (input == "spend")
                {
                    availableMoney -= transfer;
                    badDays++;
                    if (badDays >= 5)
                    {

                        break;
                    }
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }

                else if (input == "save")
                {
                    availableMoney += transfer;
                    badDays = 0;
                    //if (availableMoney >= excursionCosts)
                    //{
                    //    break;
                    //}
                }
             
            } while (availableMoney < excursionCosts);

            if (badDays >= 5)
            {

                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (availableMoney >= excursionCosts)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }


        }
    }
}
