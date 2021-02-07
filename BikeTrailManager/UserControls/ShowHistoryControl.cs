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
    public partial class ShowHistoryControl : UserControl
    {
        bool showTrail = true;
        public ShowHistoryControl()
        {
            InitializeComponent();
        }

        //sorts listview depending on clicked column
        private void trailsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    TrailsManager.SortByName();
                    break;
                case 1:
                    TrailsManager.SortByDistance();
                    break;
                case 2:
                    TrailsManager.SortByElevGain();
                    break;
                case 3:
                    TrailsManager.SortByTime();
                    break;
                case 4:
                    TrailsManager.SortByDate();
                    break;
            }
            UpdateTrailsListView();
        }

        //updates listView data
        public override void Refresh() => UpdateTrailsListView();
        
        public void UpdateTrailsListView()
        {
            SetToHistoryMode();
            trailsListView.Items.Clear();
            foreach (Trail trail in TrailsManager.trailsList)
            {
                string[] row = new string[] { trail.trailName, trail.distance.ToString() + " km", trail.elevationGain.ToString() + " m n.p.m.", $"{trail.hours}h {trail.minutes}min", $"{trail.day}.{trail.month}.{trail.year}" };
                ListViewItem lvi = new ListViewItem(row);
                trailsListView.Items.Add(lvi);
            }
        }

        //sets labels text to selected trail data
        private void SetLabelsToTrailData(int index)
        {
            trailName.Text = TrailsManager.trailsList[index].trailName;
            trailDescription.Text = TrailsManager.trailsList[index].trailDescription;
            trailAvgSpeed.Text = TrailsManager.trailsList[index].TrailAvgSpeed().ToString() + " km/h";
            trailDistance.Text = TrailsManager.trailsList[index].distance.ToString() + " km";
            trailTime.Text = $"{TrailsManager.trailsList[index].hours}h {TrailsManager.trailsList[index].minutes}min";
            trailElevationGain.Text = TrailsManager.trailsList[index].elevationGain.ToString() + " m n.p.m";
            trailDate.Text = $"{TrailsManager.trailsList[index].day}.{TrailsManager.trailsList[index].month}.{TrailsManager.trailsList[index].year}";
            trailSeason.Text = TrailsManager.FindTrailSeason(TrailsManager.trailsList[index]);
        }

        //changes visibility of trail data labels
        private void ChangeLabelsVisibilityTo(bool value)
        {
            label1.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
            label4.Visible = value;
            label5.Visible = value;
            label6.Visible = value;
            label7.Visible = value;
            label8.Visible = value;

            trailName.Visible = value;
            trailDescription.Visible = value;
            trailAvgSpeed.Visible = value;
            trailDistance.Visible = value;
            trailElevationGain.Visible = value;
            trailTime.Visible = value;
            trailDate.Visible = value;
            trailSeason.Visible = value;
            
        }



        //shows details of trail (avg speed, time, distance etc) and hides listview
        private void showTrailButton_Click(object sender, EventArgs e)
        {
            if (trailsListView.SelectedItems.Count >= 1)
            {
                if (showTrail) SetToDetailsMode();
                else SetToHistoryMode();
            }
            else MessageBox.Show("Nie wybrano żadnej trasy.");
        }

        private void SetToDetailsMode()
        {
            showTrailButton.Image = Properties.Resources.back;
            removeTrailButton.Visible = false;
            trailsListView.Visible = false;
            SetLabelsToTrailData(trailsListView.SelectedItems[0].Index);
            ChangeLabelsVisibilityTo(true);
            showTrail = false;
        }

        private void SetToHistoryMode()
        {
            trailsListView.Visible = true;
            removeTrailButton.Visible = true;
            showTrailButton.Image = Properties.Resources.showTrailButton;
            ChangeLabelsVisibilityTo(false);
            showTrail = true;
        }

        //removes a trail selected from trailsListView
        private void removeTrailButton_Click(object sender, EventArgs e)
        {
            if (trailsListView.SelectedItems.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz usunąć tą trasę?", "Uwaga", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TrailsManager.RemoveTrail(trailsListView.SelectedItems[0].Index);
                    Refresh();
                }
            }
            else MessageBox.Show("Nie wybrano żadnej trasy.");
        }

        //loads picturebox source image
        private void ShowHistoryControl_Load(object sender, EventArgs e)
        {
            showTrailButton.Image = Properties.Resources.showTrailButton;
            removeTrailButton.Image = Properties.Resources.removeTrailButton;
        }
    }
}
