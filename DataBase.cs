using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOne_Task
{
    public class DataBase
    {
        public static List<NameSetter> Database{get;} = new List<NameSetter>();

        public static void AddResult(NameSetter data)
        {
            Database.Add(data);
        }
        
    }
}