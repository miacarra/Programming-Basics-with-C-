using System;

namespace BaseballEquipment
{
    class BaseballEquipment
    {
        static void Main(string[] args)
        {
            double taxAmount = double.Parse(Console.ReadLine());
            double shoesCosts = CalculateShoesCosts(taxAmount);
            double clothesCosts = CalculateClothesCosts(shoesCosts);
            double ballCosts = CalculateBallCosts(clothesCosts);
            double accesoiriesCosts = CalculateAccessoiriesCosts(ballCosts);
            double finalCosts = taxAmount + shoesCosts + clothesCosts + ballCosts + accesoiriesCosts;
            Console.WriteLine(finalCosts);

        }
        public static double CalculateShoesCosts(double input)
        {
            double result = input -(input * 0.4);
            return result;
        }
        public static double CalculateClothesCosts(double input)
        {
            double result = input - (input * 0.2);
            return result;
        }
        public static double CalculateBallCosts(double input)
        {
            double result = input / 4;
            return result;
        }

        public static double CalculateAccessoiriesCosts(double input)
        {
            double result = input / 5;
            return result;
        }
    }
    }

