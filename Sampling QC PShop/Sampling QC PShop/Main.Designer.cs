namespace Sampling_QC_PShop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Thickness = new System.Windows.Forms.Button();
            this.Hardness = new System.Windows.Forms.Button();
            this.Glass = new System.Windows.Forms.Button();
            this.Adhesion = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 78);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 62);
            this.label1.Text = "Sampling Quality Check Paintshop";
            // 
            // Thickness
            // 
            this.Thickness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Thickness.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Thickness.Location = new System.Drawing.Point(70, 81);
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(114, 20);
            this.Thickness.TabIndex = 4;
            this.Thickness.Text = "Thickness";
            this.Thickness.Click += new System.EventHandler(this.Thickness_Click);
            // 
            // Hardness
            // 
            this.Hardness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hardness.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Hardness.Location = new System.Drawing.Point(70, 107);
            this.Hardness.Name = "Hardness";
            this.Hardness.Size = new System.Drawing.Size(114, 20);
            this.Hardness.TabIndex = 5;
            this.Hardness.Text = "Hardness";
            this.Hardness.Click += new System.EventHandler(this.Hardness_Click);
            // 
            // Glass
            // 
            this.Glass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Glass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Glass.Location = new System.Drawing.Point(70, 133);
            this.Glass.Name = "Glass";
            this.Glass.Size = new System.Drawing.Size(114, 20);
            this.Glass.TabIndex = 6;
            this.Glass.Text = "Gloss";
            this.Glass.Click += new System.EventHandler(this.Glass_Click);
            // 
            // Adhesion
            // 
            this.Adhesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Adhesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Adhesion.Location = new System.Drawing.Point(70, 159);
            this.Adhesion.Name = "Adhesion";
            this.Adhesion.Size = new System.Drawing.Size(114, 20);
            this.Adhesion.TabIndex = 7;
            this.Adhesion.Text = "Adhesion";
            this.Adhesion.Click += new System.EventHandler(this.Adhesion_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.About.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.About.Location = new System.Drawing.Point(168, 248);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(72, 20);
            this.About.TabIndex = 8;
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Report.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Report.Location = new System.Drawing.Point(168, 222);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(72, 20);
            this.Report.TabIndex = 12;
            this.Report.Text = "Report";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Adhesion);
            this.Controls.Add(this.Glass);
            this.Controls.Add(this.Hardness);
            this.Controls.Add(this.Thickness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Main";
            this.Text = "QC PanitShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Thickness;
        private System.Windows.Forms.Button Hardness;
        private System.Windows.Forms.Button Glass;
        private System.Windows.Forms.Button Adhesion;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Report;
    }
}

