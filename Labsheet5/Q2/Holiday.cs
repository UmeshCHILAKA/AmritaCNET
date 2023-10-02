using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Holiday
    {
        private string Name { get; set; }
        private int Day { get; set; }
        private string Month { get; set; }

        public Holiday(string name, int day, string month)
        {
            Name = name;
            Day = day;
            Month = month;
        }

        public bool InSameMonth(Holiday other)
        {
            return Month == other.Month;
        }

        public void DisplayHolidayDetails()
        {
            Console.WriteLine($"Day: {Day}  Month: {Month}  Name: {Name}");
        }
    }
}
