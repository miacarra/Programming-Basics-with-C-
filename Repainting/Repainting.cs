using System;

namespace Repainting
{
    class Repainting
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());  
            int paint = int.Parse(Console.ReadLine());
            int fluid = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());
            double nylonCosts = (nylon * 1.5) + 3;
            double paintCosts = (paint + (paint * 0.1)) * 14.5;
            double fluidCosts =fluid*5;
            double laborCosts = workHours*((fluidCosts + nylonCosts + paintCosts + 0.4) * 0.3);
            double totalCosts = nylonCosts + paintCosts + fluidCosts + laborCosts + 0.4;
            Console.WriteLine( totalCosts);

            
        }
        
    }
}
