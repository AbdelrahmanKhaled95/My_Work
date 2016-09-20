namespace Sampling_QC_PShop
{
    partial class Thickness_summary
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
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.avg = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 213);
            this.dataGrid1.TabIndex = 0;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(3, 219);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(72, 20);
            this.max.TabIndex = 1;
            this.max.Text = "Max";
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(78, 219);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(72, 20);
            this.min.TabIndex = 2;
            this.min.Text = "Min";
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(156, 219);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(72, 20);
            this.avg.TabIndex = 3;
            this.avg.Text = "Avg";
            this.avg.Click += new System.EventHandler(this.avg_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(78, 245);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(72, 20);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Thickness_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.back);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "Thickness_summary";
            this.Text = "Thickness_summary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button avg;
        private System.Windows.Forms.Button back;
    }
}