using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{

    public class Holiday
    {
        private string name;
        private int day;
        private string month;

        public Holiday(string name, int day, string month)
        {
            this.name = name;
            this.day = day;
            this.month = month;
        }

        public bool inSameMonth(Holiday other)
        {
            return other.month == month;
        }

        public double avgDate(Holiday[] holidays)
        {
            int dates = 0;
            foreach (var hDay in holidays)
            {
                dates += hDay.day;
            }
            return dates / (double)holidays.Length;
        }

        Holiday iDay = new Holiday("Independence Day", 4, "July");

    }


    public class Movie
    {
        private String title;
        private String studio;
        private String rating;

        public Movie(string title, string studio, string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }
        public Movie(string title, string studio):this (title, studio, "PG") { }    

        public static Movie[] getPG(Movie[] movies)
        {
             return movies.Where(m=>m.rating=="PG").ToArray(); 
        }

        Movie cr = new Movie("Casino Royale", "Eon Productions", "PG13");
    }

   
}
