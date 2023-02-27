using System;

namespace StepGoal
{
    class StepGoal
    {
        static void Main(string[] args)
        {
            string input;
            int steps;
            int goal=10000;

            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out steps))
                {
                    goal-= steps;
                }
                else if (input == "Going home")
                {
                    goal-= int.Parse(Console.ReadLine());
                    break;
                }
            } while (goal>0);
            if (goal>0)
            {

                Console.WriteLine($"{goal} more steps to reach goal");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(goal)} steps over the goal!");

            }
        
        }
    }
}
