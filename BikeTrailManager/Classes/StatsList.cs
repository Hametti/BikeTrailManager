using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeTrailManager.Classes
{
    public class StatsList
    {
        public static double avgSpeed;
        public static double elevGain;
        public static double distance;
        public static int hours;
        public static int minutes;
        public static int timeInMinutes = 60*hours + minutes;

        //resets all StatsList values to 0
        private static void ResetValues()
        {
            avgSpeed = 0;
            elevGain = 0;
            distance = 0;
            hours = 0;
            minutes = 0;
            timeInMinutes = 0;
        }

        //rounds all StatsList double fields to at most 2 decimal places
        private static void RoundDoubleValues()
        {
            avgSpeed = Math.Round(avgSpeed, 2);
            elevGain = Math.Round(elevGain, 2);
            distance = Math.Round(distance, 2);
        }

        //sets all StatsList values to values of first trail
        private static void AddSomeValuesFrom(List<Trail> trailsList)
        {
            avgSpeed = (trailsList[0].TrailAvgSpeed());
            elevGain = trailsList[0].elevationGain;
            distance = trailsList[0].distance;
            hours = trailsList[0].hours;
            minutes = trailsList[0].minutes;
            timeInMinutes = 60 * hours + minutes;
        }

        //sets all StatsList fields to founded maximum values
        public static void FindMaxValuesIn(List<Trail> trailsList)
        {
            //sets StatsList fields to first trail values which are needed for comparison
            AddSomeValuesFrom(trailsList);

            foreach (Trail obj in trailsList)
            {
                if (obj.distance > distance) distance = obj.distance;
                if (obj.TimeInMinutes() > timeInMinutes)
                {
                    hours = obj.hours;
                    minutes = obj.minutes;
                    timeInMinutes = 60 * hours + minutes;
                }
                if (obj.elevationGain > elevGain) elevGain = obj.elevationGain;
                if (obj.TrailAvgSpeed() > avgSpeed) avgSpeed = obj.TrailAvgSpeed();
            }

            //rounding values for labels clearness
            RoundDoubleValues();
        }

        //sets all StatsList fields to founded minimum values
        public static void FindMinValuesIn(List<Trail> trailsList)
        {
            AddSomeValuesFrom(trailsList);
            foreach (Trail obj in trailsList)
            {
                if (obj.distance < distance) distance = obj.distance;
                if (obj.TimeInMinutes() < timeInMinutes)
                {
                    hours = obj.hours;
                    minutes = obj.minutes;
                }
                if (obj.elevationGain < elevGain) elevGain = obj.elevationGain;
                if (obj.TrailAvgSpeed() < avgSpeed) avgSpeed = obj.TrailAvgSpeed();
            }
            RoundDoubleValues();
        }

        //sets all StatsList fields to founded average values
        public static void FindAvgValuesIn(List<Trail> trailsList)
        {
            ResetValues();

            foreach (Trail obj in trailsList)
            {
                avgSpeed += obj.TrailAvgSpeed();
                elevGain += obj.elevationGain;
                distance += obj.distance;
                timeInMinutes += obj.TimeInMinutes();
            }

            avgSpeed /= trailsList.Count;
            elevGain /= trailsList.Count;
            distance /= trailsList.Count;
            hours = (timeInMinutes / 60) / trailsList.Count;
            minutes = (timeInMinutes % 60) / trailsList.Count;

            RoundDoubleValues();
        }

        //sets all StatsList fields to sum of all values in TrailList
        public static void FindTotalValuesIn(List<Trail> trailsList)
        {
            ResetValues();

            foreach (Trail obj in trailsList)
            {
                distance += obj.distance;
                hours += obj.hours;
                minutes += obj.minutes;
            }
            hours += (minutes / 60);
            minutes = minutes % 60;

            RoundDoubleValues();
        }
    }
}
