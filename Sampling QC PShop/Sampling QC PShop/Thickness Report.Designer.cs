namespace Sampling_QC_PShop
{
    partial class Thickness_Report
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.Back = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 242);
            this.dataGrid1.TabIndex = 2;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(47, 248);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(54, 20);
            this.Back.TabIndex = 3;
            this.Back.Text = "رجوع";
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(126, 248);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(69, 20);
            this.Summary.TabIndex = 5;
            this.Summary.Text = "احصائيات";
            this.Summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // Thickness_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "Thickness_Report";
            this.Text = "Thickness Report";
            this.Load += new System.EventHandler(this.Thickness_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Summary;
    }
}