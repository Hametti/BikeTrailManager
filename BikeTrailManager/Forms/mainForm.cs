using System;
using System.Windows.Forms;
using BikeTrailManager.UserControls;
using BikeTrailManager.Classes;

namespace BikeTrailManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //loads user controls and trails list
        private void Form1_Load(object sender, EventArgs e)
        {
            RandomFactsManager.LoadRandomFactsList();
            LoadPictures();
            AddControls();
            LoadTrailList();
        }

        private void LoadPictures()
        {
            appLogo.Image = Properties.Resources.appLogo;
            addTrail.Image = Properties.Resources.addTrail;
            showHistory.Image = Properties.Resources.showHistory;
            showStats.Image = Properties.Resources.showStats;
            exit.Image = Properties.Resources.exit;
        }

        //adds controls to mainPanel
        private void AddControls()
        {
            DefaultControl defaultControl = new DefaultControl();
            defaultControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(defaultControl);

            AddTrailControl addTrailControl = new AddTrailControl();
            addTrailControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(addTrailControl);

            ShowHistoryControl showHistoryControl = new ShowHistoryControl();
            showHistoryControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(showHistoryControl);

            ShowStatsControl showStatsControl = new ShowStatsControl();
            showStatsControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(showStatsControl);

            RandomFactsControl randomFactsControl = new RandomFactsControl();
            randomFactsControl.Dock = DockStyle.Fill;
            randomFactsPanel.Controls.Add(randomFactsControl);

            mainPanel.Controls["defaultControl"].BringToFront();
        }

        //loads trail data
        private void LoadTrailList()
        {
            TrailsManager.Load(); 
        }
        private void addTrail_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["addTrailControl"].BringToFront();
        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["showHistoryControl"].Refresh();
            mainPanel.Controls["showHistoryControl"].BringToFront();
        }

        private void showStats_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["showStatsControl"].Refresh();
            mainPanel.Controls["showStatsControl"].BringToFront();
        }

        private void exit_Click(object sender, EventArgs e) => Application.ExitThread();   
    }
}
