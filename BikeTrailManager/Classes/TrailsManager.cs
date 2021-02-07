using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeTrailManager.Classes
{
    [Serializable]
    public class TrailsManager
    {
        public static List<Trail> trailsList = new List<Trail>();
        
        //adds a trail and saves updated trailsList
        public static void AddTrail(Trail obj)
        {
            trailsList.Add(obj);
            Save();
        }

        //removes a trail, and saves updated trailsList
        public static void RemoveTrail(int index)
        {
            trailsList.RemoveAt(index);
            Save();
        }

        //if value of DaysPast2020 in trail is greater than DaysPast2020 in any other trail, set it as oldest trail
        public static Trail FindOldestTrailIn(List<Trail> trailsList)
        {
            Trail oldest = trailsList[0];

            foreach (Trail obj in trailsList) if (obj.DaysPast2020() <= oldest.DaysPast2020()) oldest = obj;

            return oldest;
        }

        //if value of DaysPast2020 in trail is smaller than DaysPast2020 in any other trail, set it as last trail
        public static Trail FindLastTrailIn(List<Trail> trailsList)
        {
            Trail last = trailsList[0];

            foreach (Trail obj in trailsList) if (obj.DaysPast2020() >= last.DaysPast2020()) last = obj;

            return last;
        }

        //returns season depending on trail date
        public static string FindTrailSeason(Trail obj)
        {
            if ((obj.month > 3 && obj.month < 6) || (obj.month == 3 && obj.day > 20) || (obj.month == 6 && obj.day < 22)) return "Wiosna";
            if ((obj.month > 6 && obj.month < 9) || (obj.month == 6 && obj.day > 21) || (obj.month == 9 && obj.day < 23)) return "Lato";
            if ((obj.month > 9 && obj.month < 12) || (obj.month == 9 && obj.day > 22) || (obj.month == 12 && obj.day < 21)) return "Jesień";
            if (obj.month < 3 || (obj.month == 3 && obj.day < 21) || (obj.month == 12 && obj.day > 20)) return "Zima";
            return "";
        }

        //all sorting methods are using BubbleSort
        //sorts list by "Name" field from A-Z or Z-A
        public static void SortByName()
        {
            Trail temp;
            bool wasSorted = true;

            //checks if list was already sorted
            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                    if (trailsList[j].trailName[0] > trailsList[j + 1].trailName[0]) wasSorted = false;

            //sorts list from A-Z or Z-A depending on wasSorted variable
            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                {

                    //if list was already sorted from A-Z, sort it from Z-A
                    if (wasSorted)
                        if (trailsList[j].trailName[0] < trailsList[j + 1].trailName[0])
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }

                    //if list wasn't sorted, sort it from A-Z
                    if (!wasSorted)
                        if (trailsList[j].trailName[0] > trailsList[j + 1].trailName[0])
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                }
        }
        public static void SortByDistance()
        {
            Trail temp;
            bool wasSorted = true;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                    if (trailsList[j].distance > trailsList[j + 1].distance) wasSorted = false;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                {
                    if (wasSorted)
                        if (trailsList[j].distance < trailsList[j + 1].distance)
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                    if (!wasSorted)
                        if (trailsList[j].distance > trailsList[j + 1].distance)
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                }
        }
        public static void SortByElevGain()
        {
            Trail temp;
            bool wasSorted = true;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                    if (trailsList[j].elevationGain > trailsList[j + 1].elevationGain) wasSorted = false;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                {
                    if (wasSorted)
                        if (trailsList[j].elevationGain < trailsList[j + 1].elevationGain)
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                    if (!wasSorted)
                        if (trailsList[j].elevationGain > trailsList[j + 1].elevationGain)
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                }
        }
        public static void SortByDate()
        {
            Trail temp;
            bool wasSorted = true;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                    if (trailsList[j].DaysPast2020() > trailsList[j + 1].DaysPast2020()) wasSorted = false;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                {
                    if (wasSorted)
                        if (trailsList[j].DaysPast2020() < trailsList[j + 1].DaysPast2020())
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                    if (!wasSorted)
                        if (trailsList[j].DaysPast2020() > trailsList[j + 1].DaysPast2020())
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                }
        }
        public static void SortByTime()
        {
            Trail temp;
            bool wasSorted = true;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                    if (trailsList[j].TimeInMinutes() > trailsList[j + 1].TimeInMinutes()) wasSorted = false;

            for (int i = 0; i < trailsList.Count; i++)
                for (int j = 0; j < trailsList.Count - 1; j++)
                {
                    if (wasSorted)
                        if (trailsList[j].TimeInMinutes() < trailsList[j + 1].TimeInMinutes())
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                    if (!wasSorted)
                        if (trailsList[j].TimeInMinutes() > trailsList[j + 1].TimeInMinutes())
                        {
                            temp = trailsList[j];
                            trailsList[j] = trailsList[j + 1];
                            trailsList[j + 1] = temp;
                        }
                }
        }

        //saves trailsList data
        public static void Save()
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Trail>));
            System.IO.FileStream file;

            file = System.IO.File.Create("trailsList");
            writer.Serialize(file, trailsList);

            file.Dispose();

            file.Close();
        }

        //loads trailsList data
        public static void Load()
        {
            if(System.IO.File.Exists("trailsList"))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Trail>));
                System.IO.StreamReader file;

                file = new System.IO.StreamReader("trailsList");
                trailsList = (List<Trail>)reader.Deserialize(file);

                file.Dispose();
                file.Close();
            }
            
        }
    }
}
