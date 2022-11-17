using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOne_Task
{
    //Validation for course code
    //============================
    public class CourseCodeValidation
    {
        public static bool IsNullOrEmptyOrWhiteSpace(string courseCode)
        {
            return string.IsNullOrEmpty(courseCode.Trim());
        }

        public static bool LastThreeLetterIsInt(string courseCode)
        {
            int result;
            bool succeed = int.TryParse(courseCode.Substring(courseCode.Length - 3), out result);
            return succeed;
        }

        public static bool FirstThreeLetterIsNotString(string courseCode)
        {
            int result;
            bool confirm = int.TryParse(courseCode.Substring(0, 3), out result);
            return confirm;
        }
        
        public static bool IsSixLetterWords(string courseCode)
        {   
            int letterLength = courseCode.Length;
            return letterLength == 6;
        }

        
    }

    //Validation for course Unit
    //============================

    public class CourseUnitValidation
    {
        public static bool IsNullOrEmptyOrWhiteSpace(string  courseUnit)
        {

            return string.IsNullOrEmpty(courseUnit.Trim());
        }

        public static bool IsInt(string courseUnit)
        {
            int result;
            bool succeed = int.TryParse(courseUnit, out result);
            return succeed;
        }

        public static bool IsOneDigit(string courseUnit)
        {   
            int letterLength = courseUnit.Length;
            return letterLength == 1 ? true : false;

        }

        public static bool IsBtwOneAndFive(string courseUnit)
        {   
            int convertToInt = int.Parse(courseUnit);
            return convertToInt <= 0 || convertToInt >=6 ? true : false;
        }

    }


    //Validation for course score
    //============================
    public class CourseScoreValidation
    {
        public static bool IsNullOrEmptyOrWhiteSpace(string courseScore)
        {
            return string.IsNullOrEmpty(courseScore.Trim());
        }

        public static bool IsInt(string courseScore)
        {
            int result;
            bool succeed = int.TryParse(courseScore, out result);
            return succeed;
        }

        public static bool IsLengthLessThanOneOrGreaterThanThree(string courseScore)
        {    
            int letterLength = courseScore.Length;
            return letterLength >= 1 && letterLength <= 3 ? true : false;

        }

        public static bool IsBtwZeroAndOneHundred(string courseScore)
        {    
            int convertToInt = int.Parse(courseScore);
            return convertToInt >= 0 && convertToInt <= 100 ? true : false;
        }
    }


        //Validation for course Unit
    //============================

    public class PrintValidation
    {
        public static bool IsNullOrEmptyOrWhiteSpace(string  print)
        {

            return string.IsNullOrEmpty(print.Trim());
        }

        public static bool IsInt(string print)
        {
            int result;
            bool succeed = int.TryParse(print, out result);
            return succeed;
        }

        public static bool IsOneDigit(string print)
        {   
            int letterLength = print.Length;
            return letterLength == 1 ? true : false;

        }

        public static bool IsOneOrTwo(string print)
        {   
            int convertToInt = int.Parse(print);
            return convertToInt == 1 || convertToInt == 2 ? true : false;
        }

    }
    
}