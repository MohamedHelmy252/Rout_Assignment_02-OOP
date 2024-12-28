using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
  

    internal class HiringDate
    {

        //Property
        private int day;

        public int Day
        {
            get { return day; }
            set { try
                {
                    day = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                }
        }
        //-----------------------------------

        private int month;

        public int Month
        {
            get { return month; }
            set {
                try
                {
                    month = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                }
        }
        //-----------------------------------
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //-----------------------------------

        public int gender;

       
        //-----------------------------------

        //Constructor
        public HiringDate(int _Day , int _Month , int _Year)
        { 
            Day = _Day; 
            Month = _Month;
            Year = _Year;
        }

        //Method
        public override string ToString()
        {
            return $"{Day},{Month},{Year}";
        }

    }
}
