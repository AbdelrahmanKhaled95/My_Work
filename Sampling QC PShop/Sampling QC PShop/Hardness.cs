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
    public partial class Hardness : Form
    {
        public Hardness()
        {
           
            InitializeComponent();
        }
        public string abdo;
        private void Primal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            
        }


        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        private void Confirm_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            who();
            

            Server server = new Server();
            ConnectionString = server.getServer();
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
             SqlCommand cmd = new SqlCommand("[dbo].[upd2]", Conn);
             cmd.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter da2 = new SqlDataAdapter(cmd);
             cmd.Parameters.Add(new SqlParameter("@chassis_no", chassis2.Text));

             SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
             count.Direction = ParameterDirection.Output;
             cmd.ExecuteNonQuery();
             int x = Int32.Parse(cmd.Parameters["@count"].Value.ToString());
             
             if (x == 1)
             {
                 MessageBox.Show("رقم الشاسية مسجل بالفعل,يرجى الاتصال بالمسئول");
             }
             else
             {
                 SqlDataAdapter da = new SqlDataAdapter();
                 da.InsertCommand = new SqlCommand("insert into [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Hardness_PCQ] values(@chassis_no,@chassis_status,@hardness,GETDATE(),@username)", Conn);
                 da.InsertCommand.Connection = Conn;
                 da.InsertCommand.Parameters.Add("@chassis_no", SqlDbType.VarChar).Value = chassis2.Text;
                 da.InsertCommand.Parameters.Add("@chassis_status", SqlDbType.VarChar).Value = abdo;
                 da.InsertCommand.Parameters.Add("@hardness", SqlDbType.VarChar).Value = hardnesscombo.Text;
                 da.InsertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = login.getName();
                 da.InsertCommand.ExecuteNonQuery();
                 Conn.Close();
                 MessageBox.Show("تم");
                 Main main = new Main();
                 main.Show();
                  
             }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
             
             
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
    }
}