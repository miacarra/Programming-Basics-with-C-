using System;

namespace SuppliesForSchool
{
    class SuppliesForSchool
    {
        static void Main(string[] args)
        {
            int pens =int.Parse(Console.ReadLine());
            int markers =int.Parse(Console.ReadLine());
            int cleaningFluid =int.Parse(Console.ReadLine());
            int discount =int.Parse(Console.ReadLine());
            double price = (pens * 5.8) + (markers * 7.2) + (cleaningFluid * 1.2);
            double totalPrice = price - (price * (discount * 0.01));
            Console.WriteLine(totalPrice);
        }


    }
}
