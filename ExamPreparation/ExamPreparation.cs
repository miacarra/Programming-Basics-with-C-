using System;

namespace ExamPreparation
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            int numberOfinsuffitientGrades = int.Parse(Console.ReadLine());
            int grade = 0;
            int insufficientGrade = 0;
            int numberOfGrades = 0; 
            double totalGrade = 0;
            string input = Console.ReadLine();
            string problem = "";
            //string lastProblem = problem;
            while (input != "Enough")
            {
               problem = input;
               grade = int.Parse(Console.ReadLine());
               totalGrade += grade;
                if (grade <= 4)
                {
                    insufficientGrade++;
                    if (insufficientGrade == numberOfinsuffitientGrades)
                    {
                        break;
                    }
                    
                }
                input = Console.ReadLine();
            }
            if (insufficientGrade >= numberOfinsuffitientGrades)
            {

                Console.WriteLine($"You need a break, {insufficientGrade} poor grades.");
            }

            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(totalGrade/numberOfGrades):f2}");
                Console.WriteLine($"Number of problems: {numberOfGrades}");
                Console.WriteLine($"Last problem: {problem}");


            }

        }
    }

}