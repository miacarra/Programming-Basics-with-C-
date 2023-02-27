using System;

namespace ParkingHappyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int days =int.Parse(Console.ReadLine());
            int hours =int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;

            for (int day = 1; day <= days; day++)
            {
                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 == 1)
                    {
                        price += 2.50;
                    }
                    else if (day % 2 == 1 && hour % 2 == 0)
                    {
                        price += 1.25;
                    }
                    else
                    {
                        price += 1;
                    }
                }
                Console.WriteLine($"Day: {day} - {price:f2} leva");
                totalPrice += price;
                price = 0;
                
            }
            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
