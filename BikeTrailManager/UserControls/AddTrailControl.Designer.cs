
namespace BikeTrailManager.UserControls
{
    partial class AddTrailControl
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
            this.distance = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.elevationGain = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.addTrailButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addTrailButton)).BeginInit();
            this.SuspendLayout();
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(151, 190);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(100, 20);
            this.distance.TabIndex = 2;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(343, 190);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(27, 20);
            this.hours.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(51, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Przewyższenie[m]";
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(343, 216);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(27, 20);
            this.minutes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(277, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ilość godzin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(277, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ilość minut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(51, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dystans trasy[km]";
            // 
            // elevationGain
            // 
            this.elevationGain.Location = new System.Drawing.Point(151, 216);
            this.elevationGain.Name = "elevationGain";
            this.elevationGain.Size = new System.Drawing.Size(100, 20);
            this.elevationGain.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(54, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(316, 20);
            this.name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nazwa trasy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(51, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Opis trasy:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(54, 88);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(316, 96);
            this.description.TabIndex = 1;
            this.description.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(51, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "*Pole opcjonalne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data trasy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dzień";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(144, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Miesiąc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(246, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Rok";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(279, 261);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(47, 20);
            this.year.TabIndex = 8;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(193, 261);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(47, 20);
            this.month.TabIndex = 7;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(91, 261);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(47, 20);
            this.day.TabIndex = 6;
            // 
            // addTrailButton
            // 
            this.addTrailButton.Image = global::BikeTrailManager.Properties.Resources.addTrailButton;
            this.addTrailButton.Location = new System.Drawing.Point(54, 305);
            this.addTrailButton.Name = "addTrailButton";
            this.addTrailButton.Size = new System.Drawing.Size(120, 42);
            this.addTrailButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addTrailButton.TabIndex = 9;
            this.addTrailButton.TabStop = false;
            this.addTrailButton.Click += new System.EventHandler(this.addTrailButton_Click);
            // 
            // AddTrailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.addTrailButton);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.name);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.elevationGain);
            this.Controls.Add(this.distance);
            this.Name = "AddTrailControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.AddTrailControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addTrailButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox elevationGain;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.PictureBox addTrailButton;
    }
}
