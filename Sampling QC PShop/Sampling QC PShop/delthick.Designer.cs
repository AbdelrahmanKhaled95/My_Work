namespace Sampling_QC_PShop
{
    partial class delthick
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.Text = "رقم الشاسية";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(71, 228);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(89, 40);
            this.Back.TabIndex = 2;
            this.Back.Text = "رجوع";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(71, 91);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 34);
            this.delete.TabIndex = 3;
            this.delete.Text = "مسح";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // delthick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "delthick";
            this.Text = "delthick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button delete;
    }
}