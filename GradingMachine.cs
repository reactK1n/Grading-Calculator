using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WeekOne_Task
{

    public class GradingMachine
    {

        public void GradCalculator()
        {   
            //using List for my grading  system and creating and instance of the propertise Grading
            List<Grading> Result = new List<Grading>(); 
            //setting my increment value to 1
            int i = 1;
            //my exit condition is set to empty string
            string exit = "";
            //totalWP means total weight point
            int totalWP = 0;
            //totalGU means total grade unit
            int totalGU = 0;
     
            string courseCode = null;
            int courseUnit = 0;
            int courseScore = 0;  

            //using doWhile loop, so i can keep adding my course name and code
            do
            {
                Console.Clear();
                //error handling
                //===========================================
                do
                {
                Console.Clear();
                Console.WriteLine("input your course code");
                courseCode = Console.ReadLine().ToUpper();
                } while (courseCode == ""); 

                do
                {
                Console.Clear();
                    Console.WriteLine("input your course unit");
                    courseUnit = int.Parse(Console.ReadLine());
                } while (courseUnit <= 0 || courseUnit > 5);

                do
                {
                    Console.WriteLine("input your course score");
                    courseScore =int.Parse(Console.ReadLine()); 
                } while (courseScore < 0 || courseScore > 100);

                //=====================================
    
                //driving grading, point, and remark from the user course score
                string grade = "";
                int gradeUnit = 0;
                string remark = "";
                if (courseScore >= 70)
                {
                    grade = "A";
                    gradeUnit = 5;
                    remark = "Excellent";
                }
                else if (courseScore >= 60 && courseScore <=69)
                {
                    grade = "B";
                    gradeUnit = 4;
                    remark = "Very Good";
                }
                else if (courseScore >= 50 && courseScore <=59)
                {
                    grade = "C";
                    gradeUnit = 3;
                    remark = "Good";
                }
                else if (courseScore >= 45 && courseScore <=49)
                {
                    grade = "D";
                    gradeUnit = 2;
                    remark = "Fair";
                }
                else if (courseScore >= 40 && courseScore <=44)
                {
                    grade = "E";
                    gradeUnit = 1;
                    remark = "Pass";
                }
                else
                {
                    grade = "F";
                    gradeUnit = 0;
                    remark = "Fail";
                }
                
                int weightPt = courseUnit * gradeUnit;
                totalGU += gradeUnit; //gradeUnit should keep adding after every increment
                totalWP += weightPt; //weightPt should keep adding after every increment

                Grading Course = new Grading(){CourseCode = courseCode, CourseUnit = courseUnit, Grade = grade, GradeUnit = gradeUnit, WeightPt = weightPt, Remark = remark};
                Result.Add( Course);
                Console.WriteLine("You have registered {0} Course", i);
                Console.WriteLine("if you are through with the Course registration, Press \"Yes\" to exit, Else press \"NO\" to Continue");
                exit = Console.ReadLine().ToUpper();
                //increment should keep taking place as far as the user still has something to put down
                i++;
            }while (exit == "NO"); //once this condition is false, it should break out
                double GPA = (totalWP / totalGU);
                GPA = Math.Round(GPA, 2);            
                Console.Clear();

                //calling the table class
                DataFormatting.PrintSeperatorLine();
                DataFormatting.PrintRow(" COURSE NAME & CODE ", " COURSE UNIT ", " GRADE ", " GRADE UNIT ", " WEIGHT POINT ", " REMARK ");
                DataFormatting.PrintSeperatorLine();

            foreach(var k in Result)
            {
                // //print every result saved with looping
                DataFormatting.PrintRow(k.CourseCode, k.CourseUnit.ToString(), k.Grade, k.GradeUnit.ToString(), k.WeightPt.ToString(), k.Remark);
                DataFormatting.PrintSeperatorLine();
            }

                Console.WriteLine("Total Grade Unit Registered is {0}", totalGU);
                Console.WriteLine("Total Grade Unit Passed is {0}", totalGU);
                Console.WriteLine("Total Weight Point is {0}", totalWP);
                Console.WriteLine(String.Format("Your GPA is = {0:0.00}", GPA));



        }
    }



    //===============================================
    //setting and getting my 
    public class Grading
    {
        public string CourseCode{get; set;}
        public int CourseUnit{get; set;}
        public string Grade{get; set;}
        public int GradeUnit{get; set;}
        public int WeightPt{get; set;}
        public string Remark{get; set;}

    }
}
