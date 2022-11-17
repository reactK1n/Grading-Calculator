using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOne_Task
{
    public class PrintResult
    {
        public static void PrintData()
        {
            //totalWP means total weight point
            int totalWP = 0;
            //totalGU means total grade unit
            int totalGU = 0;
            //totalCU means total Course unit
            int totalCU = 0;

            var getData = DataBase.Database;

            DataFormatting.PrintSeperatorLine();
            DataFormatting.PrintRow(" COURSE CODE ", " COURSE UNIT ","COURSE SCORE %", " GRADE ", " GRADE UNIT ", " WEIGHT POINT ", " REMARK ");
            DataFormatting.PrintSeperatorLine();
           
            foreach(var k in getData)
            {

                DataFormatting.PrintRow(k.CourseCode, k.CourseUnit.ToString(), k.CourseScore.ToString(), k.Grade, k.GradeUnit.ToString(), k.WeightPt.ToString(), k.Remark);
                DataFormatting.PrintSeperatorLine();

                totalGU += k.GradeUnit;
                totalCU += k.CourseUnit;
                totalWP += k.WeightPt;

            }

            double GPA = (totalWP / totalCU);
            GPA = Math.Round(GPA, 2); 

            Console.WriteLine("Total Grade Unit Registered is {0}", totalGU);
            Console.WriteLine("Total Grade Unit Passed is {0}", totalGU);
            Console.WriteLine("Total Weight Point is {0}", totalWP);
            Console.WriteLine(String.Format("Your GPA is = {0:0.00}", GPA));


        }
    }
}