using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WeekOne_Task
{
    class Program
    {
        static void Main(string[] args)
        {   
            GradingMachine GradeMe = new GradingMachine();
            GradeMe.GradCalculator();
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
            Console.Clear();
        }
    }

}
