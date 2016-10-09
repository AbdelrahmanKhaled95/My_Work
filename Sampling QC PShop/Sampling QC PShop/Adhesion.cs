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
    public partial class Adhesion : Form
    {
        public string abdo;
        public string adhesionwhy;
        public Adhesion()
        {

            InitializeComponent();
        }

        private void Primal_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        private void Confirm_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            who();
            adhesionwho();
            

            Server server = new Server();
            ConnectionString = server.getServer();
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
             Conn.Open();
             SqlCommand cmd = new SqlCommand("[dbo].[upd4]", Conn);
             cmd.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter da2 = new SqlDataAdapter(cmd);
             cmd.Parameters.Add(new SqlParameter("@chassis_no", chassis3.Text));

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
                 da.InsertCommand = new SqlCommand("insert into [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Adhesion_PCQ] values(@chassis_no,@chassis_status,@adhesion,GETDATE(),@username)", Conn);
                 da.InsertCommand.Connection = Conn;
                 da.InsertCommand.Parameters.Add("@chassis_no", SqlDbType.VarChar).Value = chassis3.Text;
                 da.InsertCommand.Parameters.Add("@chassis_status", SqlDbType.VarChar).Value = abdo;
                 da.InsertCommand.Parameters.Add("@adhesion", SqlDbType.VarChar).Value = adhesionwhy;
                 da.InsertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = login.getName();
                 da.InsertCommand.ExecuteNonQuery();
                 Conn.Close();
                 MessageBox.Show("تم");
                 Main main = new Main();
                 main.Show();
                  
             }
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
        public void adhesionwho()
        {
            if (OK.Checked == true)
                adhesionwhy = "OK";
            else
                adhesionwhy = "NOT OK !";

        }

        private void Final_CheckedChanged(object sender, EventArgs e)
        {

        }

        int count = 1;
        private void chassis3_TextChanged(object sender, EventArgs e)
        {

            if (chassis3.MaxLength == count)
            {
                chassis3.ReadOnly = true;
               


            }
            count = 1 + count;
        }
    }
}