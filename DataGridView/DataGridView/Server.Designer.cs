namespace DataGridView
{
    partial class Server
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.servertext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.usertext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "SFDB_Sadat_AG_Test_2-6-2016_2";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(108, 228);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(74, 30);
            this.Connect.TabIndex = 44;
            this.Connect.Text = "اتصال";
            this.Connect.Click += new System.EventHandler(this.Connect_Click_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(103, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 46;
            this.label4.Text = "قاعدة البيانات";
            // 
            // servertext
            // 
            this.servertext.Location = new System.Drawing.Point(67, 28);
            this.servertext.Name = "servertext";
            this.servertext.Size = new System.Drawing.Size(166, 20);
            this.servertext.TabIndex = 43;
            this.servertext.Text = "10.10.11.54,1455";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(152, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "اسم السرفر";
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(67, 192);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(166, 20);
            this.passtext.TabIndex = 42;
            this.passtext.Text = "vendor@01";
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(67, 137);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(166, 20);
            this.usertext.TabIndex = 41;
            this.usertext.Text = "vendorAG\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(170, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(123, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "اسم المستخدم";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}