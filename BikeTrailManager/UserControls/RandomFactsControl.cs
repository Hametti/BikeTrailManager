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
    public partial class RandomFactsControl : UserControl
    {
        public RandomFactsControl()
        {
            InitializeComponent();
        }

        //sets label text to next random fact, and resets the timer
        private void ChangeRandomFactText()
        {
            randomFactsLabel.Text = RandomFactsManager.GetRandomFact();
            timer1.Stop();
            timer1.Start();
        }

        //timer is set to 30 seconds, and every tick label text is changing to another random fact
        private void timer1_Tick(object sender, EventArgs e) => ChangeRandomFactText();

        //set label text to random fact, after loading random facts user control
        private void RandomFactsControl_Load(object sender, EventArgs e) => ChangeRandomFactText();

        //set label to next random fact, after user clicks the panel
        private void randomFactsPanel_Click(object sender, EventArgs e) => ChangeRandomFactText();

        //changing random fact if user clicks on label, instead of panel
        private void randomFactsLabel_Click(object sender, EventArgs e) => ChangeRandomFactText();

        //changing random fact if user clicks on label, instead of panel
        private void label1_Click(object sender, EventArgs e) => ChangeRandomFactText();
    }
}
