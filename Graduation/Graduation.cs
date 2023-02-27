using System;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            int exclCounter = 0;
            int clasCounter = 0;
            int gradeCounter = 0;
            double summaryGrade = 0;
            double averageGrade = 0;
            while (clasCounter <= 12)
            {
                summaryGrade += grade;
                gradeCounter++;
               
                //if (grade >= 4)
                //{
                //    continue;
                //}
               
               if (grade<4)
                {
                    exclCounter++;

                    if (exclCounter > 1)
                    {
                        break;
                    }
                }
                clasCounter++;
                if (clasCounter >= 12)
                {

                    break;

                }

                grade = double.Parse(Console.ReadLine());
            }
            if (clasCounter >= 12)
            {
                averageGrade = summaryGrade / gradeCounter;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {clasCounter} grade");
            }
            
        }

     }

 }

