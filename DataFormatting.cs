using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WeekOne_Task
{
    public class DataFormatting
    {
        private const int Tablewidth = 150;

        public static void PrintSeperatorLine()
        {
            Console.WriteLine(new string('-', Tablewidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int columnWidth = (Tablewidth - columns.Length)/columns.Length;
            const string seed = "|";
            
            string row = columns.Aggregate(seed,(separator, columnText)=> separator + GetCenterAlligned(columnText, columnWidth) + seed);
            Console.WriteLine(row);
             
        }

        private static string GetCenterAlligned(string columnText, int columnWidth)
        {
            columnText = columnText.Length > columnWidth ? columnText.Substring(0, columnWidth - 3) + "---" : columnText;

            return string.IsNullOrEmpty(columnText) ? new string(' ', columnWidth) : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);
        }
    }

}
