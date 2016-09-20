namespace Sampling_QC_PShop
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Adhesion_Report = new System.Windows.Forms.Button();
            this.Glass_Report = new System.Windows.Forms.Button();
            this.Hardness_Report = new System.Windows.Forms.Button();
            this.Thickness_Report = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adhesion_Report
            // 
            this.Adhesion_Report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Adhesion_Report.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Adhesion_Report.Location = new System.Drawing.Point(64, 206);
            this.Adhesion_Report.Name = "Adhesion_Report";
            this.Adhesion_Report.Size = new System.Drawing.Size(114, 20);
            this.Adhesion_Report.TabIndex = 12;
            this.Adhesion_Report.Text = "Adhesion";
            this.Adhesion_Report.Click += new System.EventHandler(this.Adhesion_Report_Click);
            // 
            // Glass_Report
            // 
            this.Glass_Report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Glass_Report.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Glass_Report.Location = new System.Drawing.Point(64, 180);
            this.Glass_Report.Name = "Glass_Report";
            this.Glass_Report.Size = new System.Drawing.Size(114, 20);
            this.Glass_Report.TabIndex = 11;
            this.Glass_Report.Text = "Gloss";
            this.Glass_Report.Click += new System.EventHandler(this.Glass_Report_Click);
            // 
            // Hardness_Report
            // 
            this.Hardness_Report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hardness_Report.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Hardness_Report.Location = new System.Drawing.Point(64, 154);
            this.Hardness_Report.Name = "Hardness_Report";
            this.Hardness_Report.Size = new System.Drawing.Size(114, 20);
            this.Hardness_Report.TabIndex = 10;
            this.Hardness_Report.Text = "Hardness";
            this.Hardness_Report.Click += new System.EventHandler(this.Hardness_Report_Click);
            // 
            // Thickness_Report
            // 
            this.Thickness_Report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Thickness_Report.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Thickness_Report.Location = new System.Drawing.Point(64, 128);
            this.Thickness_Report.Name = "Thickness_Report";
            this.Thickness_Report.Size = new System.Drawing.Size(114, 20);
            this.Thickness_Report.TabIndex = 9;
            this.Thickness_Report.Text = "Thickness";
            this.Thickness_Report.Click += new System.EventHandler(this.Thickness_Report_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 62);
            this.label1.Text = "Reports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(85, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.Text = "From:";
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(73, 65);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(164, 22);
            this.Date.TabIndex = 23;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.Text = "To:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adhesion_Report);
            this.Controls.Add(this.Glass_Report);
            this.Controls.Add(this.Hardness_Report);
            this.Controls.Add(this.Thickness_Report);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adhesion_Report;
        private System.Windows.Forms.Button Glass_Report;
        private System.Windows.Forms.Button Hardness_Report;
        private System.Windows.Forms.Button Thickness_Report;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}