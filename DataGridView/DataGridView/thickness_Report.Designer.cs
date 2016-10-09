namespace DataGridView
{
    partial class thickness_Report
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
            this.Summary = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(559, 246);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(101, 27);
            this.Summary.TabIndex = 8;
            this.Summary.Text = "Summary";
            this.Summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(373, 246);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 27);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(1070, 240);
            this.dataGrid1.TabIndex = 6;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(766, 249);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 9;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // thickness_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 278);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "thickness_Report";
            this.Text = "thickness_Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Summary;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button Print;
    }
}