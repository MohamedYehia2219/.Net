using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Assignment1
{
    internal class HiringDate
    {
        #region Attributes
        private int day;
        private int month;
        private int year;
        #endregion

        public HiringDate(int day, int month , int year)
        { 
            Day = day;
            Month = month;  
            Year = year;
        }

        #region Properties
        public int Year
        {
            get { return year; }
            set
            {
                while (value < 2000 || value > DateTime.Now.Year)
                {
                    Console.WriteLine("Invalid Year, Try again...");
                    int.TryParse(Console.ReadLine(), out value);
                }
                year = value;
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                while (value <= 0 || value > 12)
                {
                    Console.WriteLine("Invalid Month, Try again...");
                    int.TryParse(Console.ReadLine(), out value);
                }
                month = value;
            }
        }
        public int Day
        {
            get { return day; }
            set
            {
                while (value <= 0 || value > 31)
                {
                    Console.WriteLine("Invalid Day, Try again...");
                    int.TryParse(Console.ReadLine(), out value);
                }
                day = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return $"Hiring Date: {month}/{day}/{year}";
        }

    }
}
