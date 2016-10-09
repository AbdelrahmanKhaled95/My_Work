namespace Sampling_QC_PShop
{
    partial class Gloss
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
            this.Primal = new System.Windows.Forms.RadioButton();
            this.Final = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chassis2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.glossno = new System.Windows.Forms.NumericUpDown();
            this.degree2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Primal
            // 
            this.Primal.Location = new System.Drawing.Point(33, 39);
            this.Primal.Name = "Primal";
            this.Primal.Size = new System.Drawing.Size(100, 20);
            this.Primal.TabIndex = 11;
            this.Primal.Text = "برايمر";
            // 
            // Final
            // 
            this.Final.Location = new System.Drawing.Point(131, 39);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(100, 20);
            this.Final.TabIndex = 10;
            this.Final.Text = "نهائى";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(136, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "رقم الشاسية";
            // 
            // chassis2
            // 
            this.chassis2.Location = new System.Drawing.Point(15, 3);
            this.chassis2.MaxLength = 20;
            this.chassis2.Name = "chassis2";
            this.chassis2.Size = new System.Drawing.Size(118, 21);
            this.chassis2.TabIndex = 9;
            this.chassis2.TextChanged += new System.EventHandler(this.chassis2_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.Text = "اللمعان";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Back.Location = new System.Drawing.Point(41, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(72, 28);
            this.Back.TabIndex = 17;
            this.Back.Text = "رجوع";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Confirm.Location = new System.Drawing.Point(143, 240);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(72, 28);
            this.Confirm.TabIndex = 15;
            this.Confirm.Text = "حفظ";
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.Text = "الزواية";
            // 
            // glossno
            // 
            this.glossno.Location = new System.Drawing.Point(131, 104);
            this.glossno.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.glossno.Name = "glossno";
            this.glossno.Size = new System.Drawing.Size(89, 22);
            this.glossno.TabIndex = 44;
            this.glossno.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // degree2
            // 
            this.degree2.Items.Add("60");
            this.degree2.Items.Add("45");
            this.degree2.Items.Add("30");
            this.degree2.Items.Add("XX");
            this.degree2.Location = new System.Drawing.Point(120, 161);
            this.degree2.Name = "degree2";
            this.degree2.Size = new System.Drawing.Size(100, 22);
            this.degree2.TabIndex = 45;
            // 
            // Gloss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.degree2);
            this.Controls.Add(this.glossno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Primal);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chassis2);
            this.Menu = this.mainMenu1;
            this.Name = "Gloss";
            this.Text = "Gloss";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Primal;
        private System.Windows.Forms.RadioButton Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chassis2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown glossno;
        private System.Windows.Forms.ComboBox degree2;
    }
}