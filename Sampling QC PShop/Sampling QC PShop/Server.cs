using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sampling_QC_PShop
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        public string getServer()
        {
            return ConnectionString;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectionString = "Server=" + servertext.Text + ";Database=" + textBox1.Text + ";"
            + "UID=" + usertext.Text + ";PWD=" + passtext.Text + "";
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            try
            {
                Conn.Open();
                MessageBox.Show("تم الاتصال بنجاح");
                Login login = new Login();
                login.Show();
                 
            }
            catch (SqlException)
            {
                MessageBox.Show("فشل الاتصال");
            }
        }
    }
}