namespace DataGridView
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.Adhesion_Report = new System.Windows.Forms.Button();
            this.Glass_Report = new System.Windows.Forms.Button();
            this.Hardness_Report = new System.Windows.Forms.Button();
            this.Thickness_Report = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "From:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(22, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 62);
            this.label1.TabIndex = 36;
            this.label1.Text = "Reports";
            // 
            // Adhesion_Report
            // 
            this.Adhesion_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Adhesion_Report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Adhesion_Report.Location = new System.Drawing.Point(86, 202);
            this.Adhesion_Report.Name = "Adhesion_Report";
            this.Adhesion_Report.Size = new System.Drawing.Size(114, 20);
            this.Adhesion_Report.TabIndex = 33;
            this.Adhesion_Report.Text = "Adhesion";
            this.Adhesion_Report.UseVisualStyleBackColor = false;
            this.Adhesion_Report.Click += new System.EventHandler(this.Adhesion_Report_Click);
            // 
            // Glass_Report
            // 
            this.Glass_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Glass_Report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Glass_Report.Location = new System.Drawing.Point(86, 176);
            this.Glass_Report.Name = "Glass_Report";
            this.Glass_Report.Size = new System.Drawing.Size(114, 20);
            this.Glass_Report.TabIndex = 32;
            this.Glass_Report.Text = "Gloss";
            this.Glass_Report.UseVisualStyleBackColor = false;
            this.Glass_Report.Click += new System.EventHandler(this.Glass_Report_Click);
            // 
            // Hardness_Report
            // 
            this.Hardness_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Hardness_Report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hardness_Report.Location = new System.Drawing.Point(86, 150);
            this.Hardness_Report.Name = "Hardness_Report";
            this.Hardness_Report.Size = new System.Drawing.Size(114, 20);
            this.Hardness_Report.TabIndex = 31;
            this.Hardness_Report.Text = "Hardness";
            this.Hardness_Report.UseVisualStyleBackColor = false;
            this.Hardness_Report.Click += new System.EventHandler(this.Hardness_Report_Click);
            // 
            // Thickness_Report
            // 
            this.Thickness_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Thickness_Report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Thickness_Report.Location = new System.Drawing.Point(86, 124);
            this.Thickness_Report.Name = "Thickness_Report";
            this.Thickness_Report.Size = new System.Drawing.Size(114, 20);
            this.Thickness_Report.TabIndex = 30;
            this.Thickness_Report.Text = "Thickness";
            this.Thickness_Report.UseVisualStyleBackColor = false;
            this.Thickness_Report.Click += new System.EventHandler(this.Thickness_Report_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // To
            // 
            this.To.CustomFormat = "yyyy-MM-dd";
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(95, 96);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(164, 20);
            this.To.TabIndex = 40;
            this.To.ValueChanged += new System.EventHandler(this.To_ValueChanged);
            // 
            // From
            // 
            this.From.CustomFormat = "yyyy-MM-dd";
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(95, 61);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(164, 20);
            this.From.TabIndex = 39;
            this.From.ValueChanged += new System.EventHandler(this.From_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adhesion_Report);
            this.Controls.Add(this.Glass_Report);
            this.Controls.Add(this.Hardness_Report);
            this.Controls.Add(this.Thickness_Report);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Button Adhesion_Report;
        private System.Windows.Forms.Button Glass_Report;
        private System.Windows.Forms.Button Hardness_Report;
        private System.Windows.Forms.Button Thickness_Report;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.DateTimePicker From;
    }
}