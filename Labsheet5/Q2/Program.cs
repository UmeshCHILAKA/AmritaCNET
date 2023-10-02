using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Holiday[] holidays = new Holiday[3];
            holidays[0] = new Holiday("May Day", 1, "May");
            holidays[1] = new Holiday("New Year", 1, "January");
            holidays[2] = new Holiday("Republic Day", 26, "January");

            Console.WriteLine("Are Republic Day and NEW YEAR in the same month? " + holidays[2].InSameMonth(holidays[1]));
           
            Console.WriteLine("Holiday Details:");
            foreach (var holiday in holidays)
            {
                holiday.DisplayHolidayDetails();
                Console.WriteLine();
            }
        }
    }
}
