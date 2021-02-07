
namespace BikeTrailManager
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.showStats = new System.Windows.Forms.PictureBox();
            this.showHistory = new System.Windows.Forms.PictureBox();
            this.randomFactsPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.addTrail = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHistory)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTrail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLogo
            // 
            this.appLogo.Image = global::BikeTrailManager.Properties.Resources.appLogo;
            this.appLogo.Location = new System.Drawing.Point(12, 12);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(102, 74);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 10;
            this.appLogo.TabStop = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::BikeTrailManager.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(12, 363);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(105, 75);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 9;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // showStats
            // 
            this.showStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showStats.Image = global::BikeTrailManager.Properties.Resources.showStats;
            this.showStats.Location = new System.Drawing.Point(12, 282);
            this.showStats.Name = "showStats";
            this.showStats.Size = new System.Drawing.Size(105, 75);
            this.showStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showStats.TabIndex = 9;
            this.showStats.TabStop = false;
            this.showStats.Click += new System.EventHandler(this.showStats_Click);
            // 
            // showHistory
            // 
            this.showHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHistory.Image = global::BikeTrailManager.Properties.Resources.showHistory;
            this.showHistory.Location = new System.Drawing.Point(12, 201);
            this.showHistory.Name = "showHistory";
            this.showHistory.Size = new System.Drawing.Size(105, 75);
            this.showHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showHistory.TabIndex = 9;
            this.showHistory.TabStop = false;
            this.showHistory.Click += new System.EventHandler(this.showHistory_Click);
            // 
            // randomFactsPanel
            // 
            this.randomFactsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randomFactsPanel.Location = new System.Drawing.Point(0, 0);
            this.randomFactsPanel.Name = "randomFactsPanel";
            this.randomFactsPanel.Size = new System.Drawing.Size(670, 44);
            this.randomFactsPanel.TabIndex = 8;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainPanel.Controls.Add(this.randomFactsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(130, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(670, 450);
            this.mainPanel.TabIndex = 3;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuPanel.Controls.Add(this.addTrail);
            this.menuPanel.Controls.Add(this.appLogo);
            this.menuPanel.Controls.Add(this.exit);
            this.menuPanel.Controls.Add(this.showHistory);
            this.menuPanel.Controls.Add(this.showStats);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(130, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // addTrail
            // 
            this.addTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTrail.Image = global::BikeTrailManager.Properties.Resources.addTrail;
            this.addTrail.Location = new System.Drawing.Point(12, 120);
            this.addTrail.Name = "addTrail";
            this.addTrail.Size = new System.Drawing.Size(105, 75);
            this.addTrail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addTrail.TabIndex = 11;
            this.addTrail.TabStop = false;
            this.addTrail.Click += new System.EventHandler(this.addTrail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 450);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trail manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHistory)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addTrail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel randomFactsPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox showStats;
        private System.Windows.Forms.PictureBox showHistory;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox addTrail;
    }
}

