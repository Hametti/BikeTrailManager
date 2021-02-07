using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeTrailManager.Classes
{
    public class Trail
    {
        public double distance;
        public int hours;
        public int minutes;
        public int elevationGain;
        public string trailName;
        public string trailDescription;
        public int day;
        public int month;
        public int year;

        public Trail(double distance, int hours, int minutes, int elevationGain, string trailName, string trailDescription, int day, int month, int year)
        {
            this.distance = distance;
            this.hours = hours;
            this.minutes = minutes;
            this.elevationGain = elevationGain;
            this.trailName = trailName;
            this.trailDescription = trailDescription;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Trail()
        {
            distance = 0;
            hours = 0;
            minutes = 0;
            elevationGain = 0;
            trailName = "Brak nazwy";
            trailDescription = "Brak nazwy";
        }


        //returns time in minutes which is needed for sort by time comparison
        public int TimeInMinutes() => 60 * hours + minutes;

        //returns trail average speed which is needed for statistics
        public double TrailAvgSpeed() => Math.Round(3.6 * (1000 * distance) / (60 * TimeInMinutes()), 2);

        //counts all days past2020 to trail date, which is needed for sorting by date
        public int DaysPast2020()
        {
            int daysPast2020 = 0 ;

            //checks if year in trail date was a leap year and adds correct amount of days
            for(int currentYear=2020; currentYear<year; currentYear++)
            {
                if ((currentYear % 4 == 0 && currentYear % 100 != 0) || year % 400 == 0) daysPast2020 += 366;
                else daysPast2020 += 365;
            }

            //returns correct amount of days in month, depending on which month is it
            switch (month)
            {
                case 1:
                    break;
                case 2:
                    daysPast2020 += 31;
                    break;
                case 3:
                    if (((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) && month > 1) daysPast2020 += 60;
                    else daysPast2020 += 59;
                    break;
                case 4:
                    daysPast2020 += 90;
                    break;
                case 5:
                    daysPast2020 += 120;
                    break;
                case 6:
                    daysPast2020 += 151;
                    break;
                case 7:
                    daysPast2020 += 181;
                    break;
                case 8:
                    daysPast2020 += 212;
                    break;
                case 9:
                    daysPast2020 += 243;
                    break;
                case 10:
                    daysPast2020 += 273;
                    break;
                case 11:
                    daysPast2020 += 304;
                    break;
                case 12:
                    daysPast2020 += 334;
                    break;
            }

            //adds "day" value
            daysPast2020 += day;

            //returns sum of days in years and months + day value
            return daysPast2020;
        }
    }
}
