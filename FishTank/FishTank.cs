using System;

namespace FishTank
{
    class FishTank
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percentage = double.Parse(Console.ReadLine());
            double aquariumCapacity = length * width * height;
            double capacityInLitres = aquariumCapacity / 1000;
            double litresNeeded = (capacityInLitres*(100 - percentage))/100;
            Console.WriteLine(litresNeeded);

        }
    }
}
