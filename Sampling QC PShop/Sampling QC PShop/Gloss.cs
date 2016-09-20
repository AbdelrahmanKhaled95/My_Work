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
    public partial class Gloss : Form
    {
        public Gloss()
        {
            InitializeComponent();
        }
        public string abdo;
        private void Back_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }


        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        private void Confirm_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            who();
            Main main = new Main();
            main.Show();
            ConnectionString = " Data Source=10.10.11.54,1455;Initial Catalog=SFDB_Sadat_AG_Test_2-6-2016_2;Persist Security Info=True;User ID=vendorAG;Password=vendor@01";
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Gloss_PCQ] values(@chassis_no,@chassis_status,@gloss,@degree,GETDATE(),@username)", Conn);
            da.InsertCommand.Connection = Conn;
            da.InsertCommand.Parameters.Add("@chassis_no", SqlDbType.VarChar).Value = chassis2.Text;
            da.InsertCommand.Parameters.Add("@chassis_status", SqlDbType.VarChar).Value = abdo;
            da.InsertCommand.Parameters.Add("@gloss" ,SqlDbType.VarChar).Value = glossno.Text;
            da.InsertCommand.Parameters.Add("@degree", SqlDbType.VarChar).Value = degree2.Text;
            da.InsertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = login.getName();
            da.InsertCommand.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Done");
        }
        public void who()
        {

            if (Primal.Checked == true)
                abdo = "primer";
            else
                abdo = "final";

        }

        int count = 1;
        private void chassis2_TextChanged(object sender, EventArgs e)
        {

            if (chassis2.MaxLength == count)
            {
                chassis2.ReadOnly = true;
               


            }
            count = 1 + count;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}