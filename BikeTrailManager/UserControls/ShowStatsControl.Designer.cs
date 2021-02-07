
namespace BikeTrailManager.UserControls
{
    partial class ShowStatsControl
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
            this.components = new System.ComponentModel.Container();
            this.maxAvgSpeed = new System.Windows.Forms.Label();
            this.maxTrailDistance = new System.Windows.Forms.Label();
            this.maxElevationGain = new System.Windows.Forms.Label();
            this.maxTrailTime = new System.Windows.Forms.Label();
            this.lastTrail = new System.Windows.Forms.Label();
            this.oldestTrail = new System.Windows.Forms.Label();
            this.avgSpeed = new System.Windows.Forms.Label();
            this.trailDistance = new System.Windows.Forms.Label();
            this.trailTime = new System.Windows.Forms.Label();
            this.elevationGain = new System.Windows.Forms.Label();
            this.minAvgSpeed = new System.Windows.Forms.Label();
            this.minTrailDistance = new System.Windows.Forms.Label();
            this.minTrailTime = new System.Windows.Forms.Label();
            this.minElevationGain = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.totalDistance = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxAvgSpeed
            // 
            this.maxAvgSpeed.AutoSize = true;
            this.maxAvgSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maxAvgSpeed.Location = new System.Drawing.Point(167, 6);
            this.maxAvgSpeed.Name = "maxAvgSpeed";
            this.maxAvgSpeed.Size = new System.Drawing.Size(13, 13);
            this.maxAvgSpeed.TabIndex = 0;
            this.maxAvgSpeed.Text = "0";
            // 
            // maxTrailDistance
            // 
            this.maxTrailDistance.AutoSize = true;
            this.maxTrailDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maxTrailDistance.Location = new System.Drawing.Point(167, 45);
            this.maxTrailDistance.Name = "maxTrailDistance";
            this.maxTrailDistance.Size = new System.Drawing.Size(13, 13);
            this.maxTrailDistance.TabIndex = 0;
            this.maxTrailDistance.Text = "0";
            // 
            // maxElevationGain
            // 
            this.maxElevationGain.AutoSize = true;
            this.maxElevationGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maxElevationGain.Location = new System.Drawing.Point(167, 19);
            this.maxElevationGain.Name = "maxElevationGain";
            this.maxElevationGain.Size = new System.Drawing.Size(13, 13);
            this.maxElevationGain.TabIndex = 0;
            this.maxElevationGain.Text = "0";
            // 
            // maxTrailTime
            // 
            this.maxTrailTime.AutoSize = true;
            this.maxTrailTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maxTrailTime.Location = new System.Drawing.Point(167, 32);
            this.maxTrailTime.Name = "maxTrailTime";
            this.maxTrailTime.Size = new System.Drawing.Size(13, 13);
            this.maxTrailTime.TabIndex = 0;
            this.maxTrailTime.Text = "0";
            // 
            // lastTrail
            // 
            this.lastTrail.AutoSize = true;
            this.lastTrail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lastTrail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastTrail.Location = new System.Drawing.Point(166, 264);
            this.lastTrail.Name = "lastTrail";
            this.lastTrail.Size = new System.Drawing.Size(13, 13);
            this.lastTrail.TabIndex = 0;
            this.lastTrail.Text = "0";
            // 
            // oldestTrail
            // 
            this.oldestTrail.AutoSize = true;
            this.oldestTrail.Cursor = System.Windows.Forms.Cursors.Default;
            this.oldestTrail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oldestTrail.Location = new System.Drawing.Point(166, 277);
            this.oldestTrail.Name = "oldestTrail";
            this.oldestTrail.Size = new System.Drawing.Size(13, 13);
            this.oldestTrail.TabIndex = 0;
            this.oldestTrail.Text = "0";
            // 
            // avgSpeed
            // 
            this.avgSpeed.AutoSize = true;
            this.avgSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avgSpeed.Location = new System.Drawing.Point(167, 158);
            this.avgSpeed.Name = "avgSpeed";
            this.avgSpeed.Size = new System.Drawing.Size(13, 13);
            this.avgSpeed.TabIndex = 0;
            this.avgSpeed.Text = "0";
            // 
            // trailDistance
            // 
            this.trailDistance.AutoSize = true;
            this.trailDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailDistance.Location = new System.Drawing.Point(167, 197);
            this.trailDistance.Name = "trailDistance";
            this.trailDistance.Size = new System.Drawing.Size(13, 13);
            this.trailDistance.TabIndex = 0;
            this.trailDistance.Text = "0";
            // 
            // trailTime
            // 
            this.trailTime.AutoSize = true;
            this.trailTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trailTime.Location = new System.Drawing.Point(167, 184);
            this.trailTime.Name = "trailTime";
            this.trailTime.Size = new System.Drawing.Size(13, 13);
            this.trailTime.TabIndex = 0;
            this.trailTime.Text = "0";
            // 
            // elevationGain
            // 
            this.elevationGain.AutoSize = true;
            this.elevationGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.elevationGain.Location = new System.Drawing.Point(167, 171);
            this.elevationGain.Name = "elevationGain";
            this.elevationGain.Size = new System.Drawing.Size(13, 13);
            this.elevationGain.TabIndex = 0;
            this.elevationGain.Text = "0";
            // 
            // minAvgSpeed
            // 
            this.minAvgSpeed.AutoSize = true;
            this.minAvgSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minAvgSpeed.Location = new System.Drawing.Point(167, 82);
            this.minAvgSpeed.Name = "minAvgSpeed";
            this.minAvgSpeed.Size = new System.Drawing.Size(13, 13);
            this.minAvgSpeed.TabIndex = 0;
            this.minAvgSpeed.Text = "0";
            // 
            // minTrailDistance
            // 
            this.minTrailDistance.AutoSize = true;
            this.minTrailDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minTrailDistance.Location = new System.Drawing.Point(167, 121);
            this.minTrailDistance.Name = "minTrailDistance";
            this.minTrailDistance.Size = new System.Drawing.Size(13, 13);
            this.minTrailDistance.TabIndex = 0;
            this.minTrailDistance.Text = "0";
            // 
            // minTrailTime
            // 
            this.minTrailTime.AutoSize = true;
            this.minTrailTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minTrailTime.Location = new System.Drawing.Point(167, 108);
            this.minTrailTime.Name = "minTrailTime";
            this.minTrailTime.Size = new System.Drawing.Size(13, 13);
            this.minTrailTime.TabIndex = 0;
            this.minTrailTime.Text = "0";
            // 
            // minElevationGain
            // 
            this.minElevationGain.AutoSize = true;
            this.minElevationGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minElevationGain.Location = new System.Drawing.Point(167, 95);
            this.minElevationGain.Name = "minElevationGain";
            this.minElevationGain.Size = new System.Drawing.Size(13, 13);
            this.minElevationGain.TabIndex = 0;
            this.minElevationGain.Text = "0";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalTime.Location = new System.Drawing.Point(166, 238);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(13, 13);
            this.totalTime.TabIndex = 0;
            this.totalTime.Text = "0";
            // 
            // totalDistance
            // 
            this.totalDistance.AutoSize = true;
            this.totalDistance.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalDistance.Location = new System.Drawing.Point(166, 251);
            this.totalDistance.Name = "totalDistance";
            this.totalDistance.Size = new System.Drawing.Size(13, 13);
            this.totalDistance.TabIndex = 0;
            this.totalDistance.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Największa prędkość średnia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Najdłuższy dystans:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Najdłuższa trasa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Największe przewyższenie:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Najniższa prędkość średnia:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(14, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Najkrótszy dystans:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(14, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Najkrótszy czas trasy:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(14, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Najmniejsze przewyższenie:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(15, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Ogólna prędkość średnia:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(14, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Średni dystans:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(14, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Średni czas trasy:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(14, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Średnie przewyższenie:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(13, 264);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Ostatnia trasa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(13, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Najstarsza trasa:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Cursor = System.Windows.Forms.Cursors.Default;
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.Location = new System.Drawing.Point(14, 238);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Całkowity czas na rowerze:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Location = new System.Drawing.Point(14, 251);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(146, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Całkowity pokonany dystans:";
            // 
            // ShowStatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.label14);
            this.Controls.Add(this.minElevationGain);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.elevationGain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxElevationGain);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.minTrailTime);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.trailTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxTrailTime);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.totalDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.oldestTrail);
            this.Controls.Add(this.lastTrail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.minTrailDistance);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.trailDistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxTrailDistance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.minAvgSpeed);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.avgSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxAvgSpeed);
            this.Name = "ShowStatsControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maxAvgSpeed;
        private System.Windows.Forms.Label maxTrailDistance;
        private System.Windows.Forms.Label maxElevationGain;
        private System.Windows.Forms.Label maxTrailTime;
        private System.Windows.Forms.Label lastTrail;
        private System.Windows.Forms.Label oldestTrail;
        private System.Windows.Forms.Label avgSpeed;
        private System.Windows.Forms.Label trailDistance;
        private System.Windows.Forms.Label trailTime;
        private System.Windows.Forms.Label elevationGain;
        private System.Windows.Forms.Label minAvgSpeed;
        private System.Windows.Forms.Label minTrailDistance;
        private System.Windows.Forms.Label minTrailTime;
        private System.Windows.Forms.Label minElevationGain;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label totalDistance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
    }
}
