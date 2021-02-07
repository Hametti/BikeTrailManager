using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeTrailManager.Classes;

namespace BikeTrailManager.UserControls
{

    public partial class ShowStatsControl : UserControl
    {
        public ShowStatsControl()
        {
            InitializeComponent();
        }

        //fill all labels with proper data
        public override void Refresh() => FillAllStats(TrailsManager.trailsList);

        //resets all labels text
        private void ResetStats()
        {
            avgSpeed.Text = "0 km/h";
            elevationGain.Text = "0 m n.p.m.";
            trailTime.Text = "0h 0 min";
            trailDistance.Text = "0 km";

            minAvgSpeed.Text = "0 km/h";
            minElevationGain.Text = "0 m n.p.m.";
            minTrailTime.Text = "0h 0 min";
            minTrailDistance.Text = "0 km";

            maxAvgSpeed.Text = "0 km/h";
            maxElevationGain.Text = "0 m n.p.m.";
            maxTrailTime.Text = "0h 0 min";
            maxTrailDistance.Text = "0 km";

            totalTime.Text = "0h 0 min";
            totalDistance.Text = "0 km";
            oldestTrail.Text = "Lista tras jest pusta";
            lastTrail.Text = "Lista tras jest pusta";
        }

        //fills all labels with text
        public void FillAllStats(List<Trail> trailsList)
        {
            ResetStats();
            if (trailsList.Count > 0)
            {
                FillMaxValues();
                FillMinValues();
                FillAvgValues();
                FillTotalValues();
            }
        }
        
        //
        //all filling methods are temporarily changing StatsList static fields to e.g. max values,
        //then changing labels text to founded e.g. max values, and adding proper units
        //
        private void FillMaxValues()
        {
            StatsList.FindMaxValuesIn(TrailsManager.trailsList);
            maxAvgSpeed.Text = StatsList.avgSpeed.ToString() + " km/h";
            maxElevationGain.Text = StatsList.elevGain.ToString() + " m n.p.m.";
            maxTrailTime.Text = StatsList.hours.ToString() + "h " + StatsList.minutes.ToString() + " min";
            maxTrailDistance.Text = StatsList.distance.ToString() + " km";
        }

        private void FillMinValues()
        {
            StatsList.FindMinValuesIn(TrailsManager.trailsList);
            minAvgSpeed.Text = StatsList.avgSpeed.ToString() + " km/h";
            minElevationGain.Text = StatsList.elevGain.ToString() + " m n.p.m.";
            minTrailTime.Text = StatsList.hours.ToString() + "h " + StatsList.minutes.ToString() + " min";
            minTrailDistance.Text = StatsList.distance.ToString() + " km";
        }
        private void FillAvgValues()
        {
            StatsList.FindAvgValuesIn(TrailsManager.trailsList);
            avgSpeed.Text = StatsList.avgSpeed.ToString() + " km/h";
            elevationGain.Text = StatsList.elevGain.ToString() + " m n.p.m.";
            trailTime.Text = StatsList.hours.ToString() + "h " + StatsList.minutes.ToString() + " min";
            trailDistance.Text = StatsList.distance.ToString() + " km";
        }
        private void FillTotalValues()
        {
            StatsList.FindTotalValuesIn(TrailsManager.trailsList);
            totalTime.Text = StatsList.hours.ToString() + "h " + StatsList.minutes.ToString() + " min";
            totalDistance.Text = StatsList.distance.ToString() + " km";
            oldestTrail.Text = TrailsManager.FindOldestTrailIn(TrailsManager.trailsList).trailName;
            lastTrail.Text = TrailsManager.FindLastTrailIn(TrailsManager.trailsList).trailName;
        }
    }
}
