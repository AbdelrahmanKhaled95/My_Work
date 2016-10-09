namespace Sampling_QC_PShop
{
    partial class Adhesion
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
            this.chassis3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Primal
            // 
            this.Primal.Location = new System.Drawing.Point(38, 56);
            this.Primal.Name = "Primal";
            this.Primal.Size = new System.Drawing.Size(100, 20);
            this.Primal.TabIndex = 7;
            this.Primal.Text = "برايمر";
            // 
            // Final
            // 
            this.Final.Location = new System.Drawing.Point(136, 56);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(100, 20);
            this.Final.TabIndex = 6;
            this.Final.Text = "نهائى";
            this.Final.CheckedChanged += new System.EventHandler(this.Final_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.Text = "رقم الشاسية";
            // 
            // chassis3
            // 
            this.chassis3.Location = new System.Drawing.Point(11, 20);
            this.chassis3.MaxLength = 20;
            this.chassis3.Name = "chassis3";
            this.chassis3.Size = new System.Drawing.Size(127, 21);
            this.chassis3.TabIndex = 5;
            this.chassis3.TextChanged += new System.EventHandler(this.chassis3_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(70, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.Text = "الاتصاق";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Back.Location = new System.Drawing.Point(38, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(72, 28);
            this.Back.TabIndex = 16;
            this.Back.Text = "رجوع";
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Confirm.Location = new System.Drawing.Point(140, 240);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(72, 28);
            this.Confirm.TabIndex = 15;
            this.Confirm.Text = "حفظ";
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click_1);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(70, 159);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 20);
            this.OK.TabIndex = 19;
            this.OK.Text = "OK";
            // 
            // Adhesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Primal);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chassis3);
            this.Menu = this.mainMenu1;
            this.Name = "Adhesion";
            this.Text = "Adhesion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Primal;
        private System.Windows.Forms.RadioButton Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chassis3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.CheckBox OK;
    }
}