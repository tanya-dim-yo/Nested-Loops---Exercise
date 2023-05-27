using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int presentationCount = 0;
            double averagePresentationGrade = 0;
            string presentationName;

            while (input != "Finish")
            {
                presentationName = input;
                double presentationTotalGrade = 0;

                for (int i = 1; i <= juryNumber; i++)
                {
                    presentationTotalGrade += double.Parse(Console.ReadLine());
                }

                presentationTotalGrade = presentationTotalGrade / juryNumber;
                averagePresentationGrade += presentationTotalGrade;

                Console.WriteLine($"{presentationName} - {presentationTotalGrade:F2}.");
                presentationCount++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {averagePresentationGrade / presentationCount:F2}.");
        }
    }
}