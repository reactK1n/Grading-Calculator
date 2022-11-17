using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOne_Task
{
    public class GradeCalculator
    {

        public static void UserInput()
        {
            string courseCode;
            string courseUnit;
            string courseScore;
            int exit;
   

            do
            {

                //Validation for course Code
                //============================
                do
                {
                    
                    Console.Write("input your course code: ");
                    courseCode = Console.ReadLine().ToUpper();
                } while
                (
                    CourseCodeValidation.IsNullOrEmptyOrWhiteSpace(courseCode)
                    || !CourseCodeValidation.LastThreeLetterIsInt(courseCode) 
                    || CourseCodeValidation.FirstThreeLetterIsString(courseCode)
                    || !CourseCodeValidation.IsSixLetterWords(courseCode)
                );


                //Validation for course UNIT
                //============================
                do
                {
                    Console.Write("input your course unit: ");
                    courseUnit = (Console.ReadLine());

                } while
                (
                    CourseUnitValidation.IsNullOrEmptyOrWhiteSpace(courseUnit) 
                    || !CourseUnitValidation.IsInt(courseUnit) 
                    || !CourseUnitValidation.IsOneDigit(courseUnit)
                    || CourseUnitValidation.IsBtwOneAndFive(courseUnit) 
                );



                //Validation for course Score
                //============================
                do
                {
                    Console.Write("input your course score: ");
                    courseScore = (Console.ReadLine());

                } while
                (
                    CourseScoreValidation.IsNullOrEmptyOrWhiteSpace(courseScore) 
                    || !CourseScoreValidation.IsInt(courseScore) 
                    || !CourseScoreValidation.IsLengthLessThanOneOrGreaterThanThree(courseScore)
                    || !CourseScoreValidation.IsBtwZeroAndOneHundred(courseScore) 
                );



            CollectingUserInput.AddData( courseCode, int.Parse(courseUnit), Convert.ToDouble(courseScore));

                Console.WriteLine("press 1 to add, 2 to Print result");
                exit = int.Parse(Console.ReadLine());

            } while (exit == 1);

            PrintResult.PrintData();


            
         
        }

    }
}