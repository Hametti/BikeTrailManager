
namespace BikeTrailManager.UserControls
{
    partial class ShowHistoryControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.trailDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trailDistance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trailTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trailAvgSpeed = new System.Windows.Forms.Label();
            this.trailDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trailName = new System.Windows.Forms.Label();
            this.trailsListView = new System.Windows.Forms.ListView();
            this.trailNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trailDistanceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trailElevGainColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trailTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trailDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showTrailButton = new System.Windows.Forms.PictureBox();
            this.removeTrailButton = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trailSeason = new System.Windows.Forms.Label();
            this.trailElevationGain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showTrailButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeTrailButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(278, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opis trasy:";
            this.label6.Visible = false;
            // 
            // trailDescription
            // 
            this.trailDescription.AutoSize = true;
            this.trailDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailDescription.Location = new System.Drawing.Point(278, 28);
            this.trailDescription.MaximumSize = new System.Drawing.Size(370, 0);
            this.trailDescription.Name = "trailDescription";
            this.trailDescription.Size = new System.Drawing.Size(13, 13);
            this.trailDescription.TabIndex = 12;
            this.trailDescription.Text = "0";
            this.trailDescription.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pokonany dystans:";
            this.label2.Visible = false;
            // 
            // trailDistance
            // 
            this.trailDistance.AutoSize = true;
            this.trailDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailDistance.Location = new System.Drawing.Point(121, 89);
            this.trailDistance.Name = "trailDistance";
            this.trailDistance.Size = new System.Drawing.Size(13, 13);
            this.trailDistance.TabIndex = 14;
            this.trailDistance.Text = "0";
            this.trailDistance.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Czas trasy:";
            this.label3.Visible = false;
            // 
            // trailTime
            // 
            this.trailTime.AutoSize = true;
            this.trailTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailTime.Location = new System.Drawing.Point(121, 102);
            this.trailTime.Name = "trailTime";
            this.trailTime.Size = new System.Drawing.Size(13, 13);
            this.trailTime.TabIndex = 16;
            this.trailTime.Text = "0";
            this.trailTime.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Prędkość średnia:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data trasy:";
            this.label4.Visible = false;
            // 
            // trailAvgSpeed
            // 
            this.trailAvgSpeed.AutoSize = true;
            this.trailAvgSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailAvgSpeed.Location = new System.Drawing.Point(121, 76);
            this.trailAvgSpeed.Name = "trailAvgSpeed";
            this.trailAvgSpeed.Size = new System.Drawing.Size(13, 13);
            this.trailAvgSpeed.TabIndex = 19;
            this.trailAvgSpeed.Text = "0";
            this.trailAvgSpeed.Visible = false;
            // 
            // trailDate
            // 
            this.trailDate.AutoSize = true;
            this.trailDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailDate.Location = new System.Drawing.Point(121, 128);
            this.trailDate.Name = "trailDate";
            this.trailDate.Size = new System.Drawing.Size(13, 13);
            this.trailDate.TabIndex = 20;
            this.trailDate.Text = "0";
            this.trailDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nazwa trasy:";
            this.label1.Visible = false;
            // 
            // trailName
            // 
            this.trailName.AutoSize = true;
            this.trailName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailName.Location = new System.Drawing.Point(18, 28);
            this.trailName.MaximumSize = new System.Drawing.Size(250, 0);
            this.trailName.Name = "trailName";
            this.trailName.Size = new System.Drawing.Size(13, 13);
            this.trailName.TabIndex = 22;
            this.trailName.Text = "0";
            this.trailName.Visible = false;
            // 
            // trailsListView
            // 
            this.trailsListView.BackColor = System.Drawing.Color.White;
            this.trailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trailNameColumn,
            this.trailDistanceColumn,
            this.trailElevGainColumn,
            this.trailTimeColumn,
            this.trailDateColumn});
            this.trailsListView.FullRowSelect = true;
            this.trailsListView.GridLines = true;
            this.trailsListView.HideSelection = false;
            this.trailsListView.Location = new System.Drawing.Point(34, 31);
            this.trailsListView.Name = "trailsListView";
            this.trailsListView.Size = new System.Drawing.Size(575, 282);
            this.trailsListView.TabIndex = 2;
            this.trailsListView.UseCompatibleStateImageBehavior = false;
            this.trailsListView.View = System.Windows.Forms.View.Details;
            this.trailsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.trailsListView_ColumnClick);
            // 
            // trailNameColumn
            // 
            this.trailNameColumn.Text = "Nazwa trasy";
            this.trailNameColumn.Width = 187;
            // 
            // trailDistanceColumn
            // 
            this.trailDistanceColumn.Text = "Dystans";
            // 
            // trailElevGainColumn
            // 
            this.trailElevGainColumn.Text = "Przewyższenie";
            this.trailElevGainColumn.Width = 94;
            // 
            // trailTimeColumn
            // 
            this.trailTimeColumn.Text = "Czas";
            this.trailTimeColumn.Width = 79;
            // 
            // trailDateColumn
            // 
            this.trailDateColumn.Text = "Data";
            this.trailDateColumn.Width = 90;
            // 
            // showTrailButton
            // 
            this.showTrailButton.Image = global::BikeTrailManager.Properties.Resources.showTrailButton;
            this.showTrailButton.Location = new System.Drawing.Point(34, 319);
            this.showTrailButton.Name = "showTrailButton";
            this.showTrailButton.Size = new System.Drawing.Size(120, 42);
            this.showTrailButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showTrailButton.TabIndex = 23;
            this.showTrailButton.TabStop = false;
            this.showTrailButton.Click += new System.EventHandler(this.showTrailButton_Click);
            // 
            // removeTrailButton
            // 
            this.removeTrailButton.Image = global::BikeTrailManager.Properties.Resources.removeTrailButton;
            this.removeTrailButton.Location = new System.Drawing.Point(160, 319);
            this.removeTrailButton.Name = "removeTrailButton";
            this.removeTrailButton.Size = new System.Drawing.Size(120, 42);
            this.removeTrailButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeTrailButton.TabIndex = 23;
            this.removeTrailButton.TabStop = false;
            this.removeTrailButton.Click += new System.EventHandler(this.removeTrailButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(18, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Przewyższenie";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(18, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pora roku:";
            this.label7.Visible = false;
            // 
            // trailSeason
            // 
            this.trailSeason.AutoSize = true;
            this.trailSeason.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailSeason.Location = new System.Drawing.Point(121, 141);
            this.trailSeason.Name = "trailSeason";
            this.trailSeason.Size = new System.Drawing.Size(13, 13);
            this.trailSeason.TabIndex = 17;
            this.trailSeason.Text = "0";
            this.trailSeason.Visible = false;
            // 
            // trailElevationGain
            // 
            this.trailElevationGain.AutoSize = true;
            this.trailElevationGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailElevationGain.Location = new System.Drawing.Point(121, 115);
            this.trailElevationGain.Name = "trailElevationGain";
            this.trailElevationGain.Size = new System.Drawing.Size(13, 13);
            this.trailElevationGain.TabIndex = 17;
            this.trailElevationGain.Text = "0";
            this.trailElevationGain.Visible = false;
            // 
            // ShowHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.removeTrailButton);
            this.Controls.Add(this.showTrailButton);
            this.Controls.Add(this.trailName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trailDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trailAvgSpeed);
            this.Controls.Add(this.trailDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trailElevationGain);
            this.Controls.Add(this.trailSeason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trailTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trailDescription);
            this.Controls.Add(this.trailsListView);
            this.Name = "ShowHistoryControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.ShowHistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showTrailButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeTrailButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView trailsListView;
        private System.Windows.Forms.ColumnHeader trailNameColumn;
        private System.Windows.Forms.ColumnHeader trailDistanceColumn;
        private System.Windows.Forms.ColumnHeader trailElevGainColumn;
        private System.Windows.Forms.ColumnHeader trailTimeColumn;
        private System.Windows.Forms.ColumnHeader trailDateColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label trailDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trailDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trailTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label trailAvgSpeed;
        private System.Windows.Forms.Label trailDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label trailName;
        private System.Windows.Forms.PictureBox showTrailButton;
        private System.Windows.Forms.PictureBox removeTrailButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label trailSeason;
        private System.Windows.Forms.Label trailElevationGain;
    }
}
