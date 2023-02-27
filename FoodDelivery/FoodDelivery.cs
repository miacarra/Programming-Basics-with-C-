using System;

namespace FoodDelivery
{
    class FoodDelivery
    {

        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggieMenus = int.Parse(Console.ReadLine());
            double chickenMenuCosts = CalculateChickenMenu(chickenMenus);
            double fishMenuCosts = CalculateFishMenu(fishMenus);
            double veggieMenuCosts = CalculateVeggieMenu(veggieMenus);
            double foodCosts = chickenMenuCosts + fishMenuCosts + veggieMenuCosts;
            double dessertCosts = CalculateDessertCosts(foodCosts);
            double finalCosts = chickenMenuCosts + fishMenuCosts + veggieMenuCosts + dessertCosts + 2.5;
            Console.WriteLine(finalCosts); 
        }
            public static double CalculateChickenMenu(int chickenMenus)
            {
            double chickenMenuPrice = chickenMenus * 10.35;
            return chickenMenuPrice;
         }

        public static double CalculateFishMenu(int fishMenus)
        {
            double fishMenuPrice = fishMenus * 12.4;
            return fishMenuPrice;
        }

        public static double CalculateVeggieMenu(int veggieMenus)
        {
            double veggieMenuPrice = veggieMenus * 8.15;
            return veggieMenuPrice;
        }
        public static double CalculateDessertCosts(double number1)
        {
            double dessertCosts = number1 * 0.2;
            return dessertCosts;
        }
    }
}
