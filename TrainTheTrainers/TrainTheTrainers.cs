using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            int numberTrainers=int.Parse(Console.ReadLine());
            int counter = 0;
            string input= Console.ReadLine();
            string presentationName;
            double grade=0;
            double averageGrade=0;
            double totalGrades=0;
            
            while (input != "Finish")
            {
                grade =0;
                presentationName = input;
                
                for (int trainers = 1; trainers <= numberTrainers; trainers++)
                {
                    grade += double.Parse(Console.ReadLine());
                    counter++;
                }
                averageGrade = grade / numberTrainers;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
                totalGrades +=averageGrade;
                input =Console.ReadLine();
            }
            if (input == "Finish")
            {

                Console.WriteLine($"Student's final assessment is {(totalGrades/counter):f2}.");
            }
            }
    }
}
