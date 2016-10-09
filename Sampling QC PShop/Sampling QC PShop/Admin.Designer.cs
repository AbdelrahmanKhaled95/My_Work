namespace Sampling_QC_PShop
{
    partial class Admin
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
            this.Adhesion = new System.Windows.Forms.Button();
            this.Glass = new System.Windows.Forms.Button();
            this.Hardness = new System.Windows.Forms.Button();
            this.Thickness = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adhesion
            // 
            this.Adhesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Adhesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Adhesion.Location = new System.Drawing.Point(63, 163);
            this.Adhesion.Name = "Adhesion";
            this.Adhesion.Size = new System.Drawing.Size(114, 20);
            this.Adhesion.TabIndex = 11;
            this.Adhesion.Text = "الالتصاق";
            this.Adhesion.Click += new System.EventHandler(this.Adhesion_Click);
            // 
            // Glass
            // 
            this.Glass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Glass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Glass.Location = new System.Drawing.Point(63, 137);
            this.Glass.Name = "Glass";
            this.Glass.Size = new System.Drawing.Size(114, 20);
            this.Glass.TabIndex = 10;
            this.Glass.Text = "اللمعان";
            this.Glass.Click += new System.EventHandler(this.Glass_Click);
            // 
            // Hardness
            // 
            this.Hardness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hardness.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Hardness.Location = new System.Drawing.Point(63, 111);
            this.Hardness.Name = "Hardness";
            this.Hardness.Size = new System.Drawing.Size(114, 20);
            this.Hardness.TabIndex = 9;
            this.Hardness.Text = "الصلادة";
            this.Hardness.Click += new System.EventHandler(this.Hardness_Click);
            // 
            // Thickness
            // 
            this.Thickness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Thickness.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Thickness.Location = new System.Drawing.Point(63, 85);
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(114, 20);
            this.Thickness.TabIndex = 8;
            this.Thickness.Text = "السمك";
            this.Thickness.Click += new System.EventHandler(this.Thickness_Click_1);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Back.Location = new System.Drawing.Point(86, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(72, 28);
            this.Back.TabIndex = 18;
            this.Back.Text = "رجوع";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Adhesion);
            this.Controls.Add(this.Glass);
            this.Controls.Add(this.Hardness);
            this.Controls.Add(this.Thickness);
            this.Menu = this.mainMenu1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adhesion;
        private System.Windows.Forms.Button Glass;
        private System.Windows.Forms.Button Hardness;
        private System.Windows.Forms.Button Thickness;
        private System.Windows.Forms.Button Back;
    }
}