using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOne_Task
{
    public class NameSetter
    {
        public string Id{get;} = Guid.NewGuid().ToString();
        public string CourseCode{get; set;}
        public int CourseUnit{get; set;}
        public double CourseScore{get; set;}
        public string Grade
        {
            get
            {
                switch (CourseScore)
                {
                    case >= 70:
                        return Grades.A.ToString();
                    case >= 60:
                        return Grades.B.ToString();
                    case >= 50:
                        return Grades.C.ToString();
                    case >= 45:
                        return Grades.D.ToString();
                    case >= 40:
                        return Grades.E.ToString();
                    default:
                        return Grades.F.ToString();
                }
            }
        }
        public string Remark
        {
            get
            {
                switch (CourseScore)
                {
                    case >= 70:
                        return Remarks.Excellent.ToString();
                    case >= 60:
                        return Remarks.VeryGood.ToString();
                    case >= 50:
                        return Remarks.Good.ToString();
                    case >= 45:
                        return Remarks.Fair.ToString();
                    case >= 40:
                        return Remarks.Pass.ToString();
                    default:
                        return Remarks.Fail.ToString();
                }
            }
        }
        public int WeightPt
        {
            get
            {
                 return CourseUnit * GradeUnit;
            }
        }
        public int GradeUnit
        {
            get
            {
                switch (CourseScore)
                {
                    case >= 70:
                        return 5;
                    case >= 60:
                        return 4;
                    case >= 50:
                        return 3;
                    case >= 45:
                        return 2;
                    case >= 40:
                        return 1;
                    default:
                        return 0;
                }
            }
        }
    }
}