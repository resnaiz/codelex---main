using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_14
{
    internal class Date
    {
        int year;
        int month;
        int day;

        public Date(int yearInfo, int monthInfo, int dayInfo)
        {
            this.year = yearInfo;
            this.month = monthInfo;
            this.day = dayInfo;
        }

        public string WeekdayInDutch()
        {
            DateTime dateTime = new DateTime(year, month, day);
            return dateTime.ToString("dddd", new System.Globalization.CultureInfo("nl-NL"));
        }
    }
}
