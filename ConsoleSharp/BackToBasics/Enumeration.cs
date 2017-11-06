using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSharp.BackToBasics
{
    public class Enumeration
    {
        public enum WorkingDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        public void LoopEnumGetNames()
        {
            foreach(var item in Enum.GetNames(typeof(WorkingDays)))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void LoopEnumGetValues()
        {
            foreach (var item in Enum.GetValues(typeof(WorkingDays)))
            {
                Console.WriteLine(item);
                Console.WriteLine(Convert.ToInt32(item));
            }
            Console.ReadLine();
        }
    }
}
