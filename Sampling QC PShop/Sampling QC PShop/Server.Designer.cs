namespace Sampling_QC_PShop
{
    partial class Server
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
            this.label4 = new System.Windows.Forms.Label();
            this.servertext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.usertext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(103, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.Text = "قاعدة البيانات";
            // 
            // servertext
            // 
            this.servertext.Location = new System.Drawing.Point(40, 31);
            this.servertext.Name = "servertext";
            this.servertext.Size = new System.Drawing.Size(166, 21);
            this.servertext.TabIndex = 20;
            this.servertext.Text = "10.10.11.54,1455";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(120, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.Text = "اسم السرفر";
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(40, 196);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(166, 21);
            this.passtext.TabIndex = 19;
            this.passtext.Text = "vendor@01";
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(40, 141);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(166, 21);
            this.usertext.TabIndex = 18;
            this.usertext.Text = "vendorAG\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(120, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(73, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.Text = "اسم المستخدم";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(80, 238);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(74, 30);
            this.Connect.TabIndex = 26;
            this.Connect.Text = "اتصال";
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 21);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "SFDB_Sadat_AG_Test_2-6-2016_2";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.servertext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.usertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox textBox1;
    }
}