using System;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {


            string input;
            double price;
            // int savings = 0;
            string destination = "";
            do
            {
                input = Console.ReadLine();
               
                if (input == "End")
                {
                    break;
                }
                else
                {
                    destination = input;
                    price = double.Parse(Console.ReadLine());
                    do
                    {

                        price -= double.Parse(Console.ReadLine());
                    } while (price > 0);
                   
                    if (price <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");

                    }
                }

            } while (input != "End");
        }
    }
    
}