using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataGridView
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
            try
            {
                Main main = new Main();
                Server server = new Server();
                ConnectionString = server.getServer();
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
                {

                    main.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("ليس لديك تصريح دخول");
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("من فضلك,ادخل سيرفر للاتصال بة");
            }

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
            this.Hide();
        }

      
    }
}
