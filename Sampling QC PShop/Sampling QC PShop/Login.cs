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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string getName()
        {
            return name;
        }
        public string getTextBox2()
        {
            return textBox2.Text;
        }
        public static string name;

        
        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        private void Login_button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            ConnectionString = " Data Source=10.10.11.54,1455;Initial Catalog=SFDB_Sadat_AG_Test_2-6-2016_2;Persist Security Info=True;User ID=vendorAG;Password=vendor@01";
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlCommand cmd = new SqlCommand("try1", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@username", textBox1.Text));
            name = textBox1.Text;
            cmd.Parameters.Add(new SqlParameter("@password", textBox2.Text));
            SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
            count.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int x = Int32.Parse(cmd.Parameters["@count"].Value.ToString());
            if (x == 1)
                main.Show();
            else
                MessageBox.Show("You have no access");
            Conn.Close();

        }
    }
}