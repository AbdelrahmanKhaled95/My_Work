namespace Sampling_QC_PShop
{
    partial class Thickness
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
            this.Chassis_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.RadioButton();
            this.Primal = new System.Windows.Forms.RadioButton();
            this.hardwareButton1 = new Microsoft.WindowsCE.Forms.HardwareButton();
            this.Confirm = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Fender_LF = new System.Windows.Forms.NumericUpDown();
            this.Door_RR = new System.Windows.Forms.NumericUpDown();
            this.Door_LF = new System.Windows.Forms.NumericUpDown();
            this.Door_LR = new System.Windows.Forms.NumericUpDown();
            this.Hood = new System.Windows.Forms.NumericUpDown();
            this.Roof = new System.Windows.Forms.NumericUpDown();
            this.Truck_lid = new System.Windows.Forms.NumericUpDown();
            this.Fender_LR = new System.Windows.Forms.NumericUpDown();
            this.Door_RF = new System.Windows.Forms.NumericUpDown();
            this.Fender_RR = new System.Windows.Forms.NumericUpDown();
            this.fender_RF = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // Chassis_no
            // 
            this.Chassis_no.Location = new System.Drawing.Point(10, 3);
            this.Chassis_no.MaxLength = 20;
            this.Chassis_no.Name = "Chassis_no";
            this.Chassis_no.Size = new System.Drawing.Size(127, 21);
            this.Chassis_no.TabIndex = 0;
            this.Chassis_no.TextChanged += new System.EventHandler(this.Chassis_no_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(151, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.Text = "رقم الشاسية";
            // 
            // Final
            // 
            this.Final.Location = new System.Drawing.Point(140, 40);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(100, 20);
            this.Final.TabIndex = 2;
            this.Final.Text = "نهائى";
            // 
            // Primal
            // 
            this.Primal.Location = new System.Drawing.Point(27, 40);
            this.Primal.Name = "Primal";
            this.Primal.Size = new System.Drawing.Size(100, 20);
            this.Primal.TabIndex = 3;
            this.Primal.Text = "برايمر";
            this.Primal.CheckedChanged += new System.EventHandler(this.Primal_CheckedChanged);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Confirm.Location = new System.Drawing.Point(140, 240);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(72, 28);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "حفظ";
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Back.Location = new System.Drawing.Point(41, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(72, 28);
            this.Back.TabIndex = 14;
            this.Back.Text = "رجوع";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(63, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 22);
            this.label2.Text = "كبود";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(63, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.Text = "سقف";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(63, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.Text = "شنطة";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(121, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 22);
            this.label5.Text = "ر/أ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(121, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 22);
            this.label6.Text = "ر/خ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(0, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.Text = "ر/أ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(0, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 22);
            this.label8.Text = "ر/خ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(121, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 22);
            this.label9.Text = "ب/خ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(121, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 22);
            this.label10.Text = "ب/أ";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(0, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 22);
            this.label11.Text = "ب/أ";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(0, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.Text = "ب/خ";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.Text = "الجانب الايسر";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(130, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.Text = "الجانب الايمن";
            // 
            // Fender_LF
            // 
            this.Fender_LF.Location = new System.Drawing.Point(41, 88);
            this.Fender_LF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Fender_LF.Name = "Fender_LF";
            this.Fender_LF.Size = new System.Drawing.Size(74, 22);
            this.Fender_LF.TabIndex = 15;
            // 
            // Door_RR
            // 
            this.Door_RR.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Door_RR.Location = new System.Drawing.Point(41, 108);
            this.Door_RR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Door_RR.Name = "Door_RR";
            this.Door_RR.Size = new System.Drawing.Size(74, 20);
            this.Door_RR.TabIndex = 39;
            // 
            // Door_LF
            // 
            this.Door_LF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Door_LF.Location = new System.Drawing.Point(41, 127);
            this.Door_LF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Door_LF.Name = "Door_LF";
            this.Door_LF.Size = new System.Drawing.Size(74, 20);
            this.Door_LF.TabIndex = 40;
                  // 
            // Door_LR
            // 
            this.Door_LR.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Door_LR.Location = new System.Drawing.Point(41, 143);
            this.Door_LR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Door_LR.Name = "Door_LR";
            this.Door_LR.Size = new System.Drawing.Size(74, 20);
            this.Door_LR.TabIndex = 41;
         
            // 
            // Hood
            // 
            this.Hood.Location = new System.Drawing.Point(119, 215);
            this.Hood.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Hood.Name = "Hood";
            this.Hood.Size = new System.Drawing.Size(89, 22);
            this.Hood.TabIndex = 16;
          
            // 
            // Roof
            // 
            this.Roof.Location = new System.Drawing.Point(119, 194);
            this.Roof.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Roof.Name = "Roof";
            this.Roof.Size = new System.Drawing.Size(89, 22);
            this.Roof.TabIndex = 59;
          
            // 
            // Truck_lid
            // 
            this.Truck_lid.Location = new System.Drawing.Point(119, 171);
            this.Truck_lid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Truck_lid.Name = "Truck_lid";
            this.Truck_lid.Size = new System.Drawing.Size(89, 22);
            this.Truck_lid.TabIndex = 43;
          
            // 
            // Fender_LR
            // 
            this.Fender_LR.Location = new System.Drawing.Point(152, 141);
            this.Fender_LR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Fender_LR.Name = "Fender_LR";
            this.Fender_LR.Size = new System.Drawing.Size(88, 22);
            this.Fender_LR.TabIndex = 29;
          
            // 
            // Door_RF
            // 
            this.Door_RF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.Door_RF.Location = new System.Drawing.Point(152, 123);
            this.Door_RF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Door_RF.Name = "Door_RF";
            this.Door_RF.Size = new System.Drawing.Size(88, 20);
            this.Door_RF.TabIndex = 38;
         
            // 
            // Fender_RR
            // 
            this.Fender_RR.Location = new System.Drawing.Point(152, 102);
            this.Fender_RR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Fender_RR.Name = "Fender_RR";
            this.Fender_RR.Size = new System.Drawing.Size(88, 22);
            this.Fender_RR.TabIndex = 28;
          
            // 
            // fender_RF
            // 
            this.fender_RF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.fender_RF.Location = new System.Drawing.Point(152, 85);
            this.fender_RF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fender_RF.Name = "fender_RF";
            this.fender_RF.Size = new System.Drawing.Size(88, 20);
            this.fender_RF.TabIndex = 27;
         
            // 
            // Thickness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Roof);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Truck_lid);
            this.Controls.Add(this.Door_LR);
            this.Controls.Add(this.Door_LF);
            this.Controls.Add(this.Door_RR);
            this.Controls.Add(this.Door_RF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Fender_LR);
            this.Controls.Add(this.Fender_RR);
            this.Controls.Add(this.fender_RF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hood);
            this.Controls.Add(this.Fender_LF);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Primal);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chassis_no);
            this.Menu = this.mainMenu1;
            this.Name = "Thickness";
            this.Text = "Thickness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Chassis_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Final;
        private System.Windows.Forms.RadioButton Primal;
        private Microsoft.WindowsCE.Forms.HardwareButton hardwareButton1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Fender_LF;
        private System.Windows.Forms.NumericUpDown Door_RR;
        private System.Windows.Forms.NumericUpDown Door_LF;
        private System.Windows.Forms.NumericUpDown Door_LR;
        private System.Windows.Forms.NumericUpDown Hood;
        private System.Windows.Forms.NumericUpDown Roof;
        private System.Windows.Forms.NumericUpDown Truck_lid;
        private System.Windows.Forms.NumericUpDown Fender_LR;
        private System.Windows.Forms.NumericUpDown Door_RF;
        private System.Windows.Forms.NumericUpDown Fender_RR;
        private System.Windows.Forms.NumericUpDown fender_RF;
    }
}