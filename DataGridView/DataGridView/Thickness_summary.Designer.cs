namespace DataGridView
{
    partial class Thickness_summary
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
            this.back = new System.Windows.Forms.Button();
            this.avg = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(512, 239);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(72, 20);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(590, 208);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(72, 25);
            this.avg.TabIndex = 8;
            this.avg.Text = "Avg";
            this.avg.Click += new System.EventHandler(this.avg_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(512, 208);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(72, 25);
            this.min.TabIndex = 7;
            this.min.Text = "Min";
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(434, 208);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(72, 25);
            this.max.TabIndex = 6;
            this.max.Text = "Max";
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, -2);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(1074, 213);
            this.dataGrid1.TabIndex = 5;
            // 
            // Thickness_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 261);
            this.Controls.Add(this.back);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "Thickness_summary";
            this.Text = "Thickness_summary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button avg;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.DataGrid dataGrid1;
    }
}