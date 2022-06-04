using System;
namespace While
{
    class Program
    {
        static void Main()
        {
            //INPUT
            string nameOfStudent = Console.ReadLine();
            double finalYearlyGrade = 0;
            int totalYears = 0;

            //ACTIONS
            while (totalYears < 12)
            {
                double gradeFromCurrClass = double.Parse(Console.ReadLine());

                if (gradeFromCurrClass >= 4)
                {
                    totalYears++;
                    finalYearlyGrade += gradeFromCurrClass;
                }
                else
                {
                    totalYears++;
                    if (totalYears >= 1)
                    {
                        Console.WriteLine($"{nameOfStudent} has been excluded at {totalYears} grade");
                        return;
                    }                 
                }
              }
            //OUTPUT
            double avrgGrade = finalYearlyGrade / totalYears;
            Console.WriteLine($"{nameOfStudent} graduated. Average grade: {avrgGrade:f2}");
            


        }
    }
}

