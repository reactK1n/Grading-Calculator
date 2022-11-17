using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOne_Task
{
    public class CollectingUserInput
    {
        public static void AddData(string courseCode, int courseUnit, double courseScore)
        {
            NameSetter myData = new NameSetter
            {
                CourseCode = courseCode,
                CourseUnit = courseUnit,
                CourseScore = courseScore
            };

            DataBase.AddResult(myData);
        }
    }
}