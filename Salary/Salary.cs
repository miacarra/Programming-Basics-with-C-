using System;

namespace Salary
{
    class Salary
    {
        static void Main(string[] args)
        {
            int openTabs =int.Parse(Console.ReadLine());
            double salary =double.Parse(Console.ReadLine());
            string tab;
            for (int i = 0; i < openTabs; i++)
            {
                tab = Console.ReadLine();
                if (tab == "Facebook")
                {
                    salary-= 150;
                   
                }
                if (tab == "Instagram")
                {
                    salary -= 100;
                }
                if (tab == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    break;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }

        }
    }
}
