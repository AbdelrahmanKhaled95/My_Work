using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sampling_QC_PShop
{
    public partial class Thickness : Form
    {
       
        public string abdo;
        public Thickness()
        {
            InitializeComponent();
        }

        private void Primal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }

     

        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        DataTable dt;
        private void Confirm_Click(object sender, EventArgs e)
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
            da.InsertCommand = new SqlCommand("insert into [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Thickness_PCQ] values(@chassis_no,@chassis_status,@Fender_Rf,@Fender_Lf,@Door_Rf,@Door_Lf,@Fender_Rr,@Fender_Lr,@Door_Rr,@Door_Lr,@hood,@roof,@truck_lid,GETDATE(),@username)", Conn);
            da.InsertCommand.Connection = Conn;
            da.InsertCommand.Parameters.Add("@chassis_no", SqlDbType.VarChar).Value = Chassis_no.Text;
            da.InsertCommand.Parameters.Add("@chassis_status", SqlDbType.VarChar).Value = abdo;
            da.InsertCommand.Parameters.Add("@Fender_Rf", SqlDbType.VarChar).Value = fender_RF.Value;
            da.InsertCommand.Parameters.Add("@Fender_Lf", SqlDbType.VarChar).Value = Fender_LF.Value;
            da.InsertCommand.Parameters.Add("@Door_Rf", SqlDbType.VarChar).Value = Door_RF.Value;
            da.InsertCommand.Parameters.Add("@Door_Lf", SqlDbType.VarChar).Value = Door_LF.Value;
            da.InsertCommand.Parameters.Add("@Fender_Rr", SqlDbType.VarChar).Value = Fender_RR.Value;
            da.InsertCommand.Parameters.Add("@Fender_Lr", SqlDbType.VarChar).Value = Fender_LR.Value;
            da.InsertCommand.Parameters.Add("@Door_Rr", SqlDbType.VarChar).Value = Door_LR.Value;
            da.InsertCommand.Parameters.Add("@Door_Lr", SqlDbType.VarChar).Value = Door_LR.Value;
            da.InsertCommand.Parameters.Add("@hood", SqlDbType.VarChar).Value = Hood.Value;
            da.InsertCommand.Parameters.Add("@roof", SqlDbType.VarChar).Value = Roof.Value;
            da.InsertCommand.Parameters.Add("@truck_lid", SqlDbType.VarChar).Value = Truck_lid.Value;
            da.InsertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = login.getName();


            da.InsertCommand.ExecuteNonQuery();
            Conn.Close();
            
                MessageBox.Show("Done");
            
           


        }



        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void Thickness_Load(object sender, EventArgs e)
        {

        }

        private void Final_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label7_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label4_ParentChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }
        public void who()
        {

            if (Primal.Checked == true)
                abdo = "primer";
            else
                abdo = "final";

        }
        int count = 1;
        private void Chassis_no_TextChanged(object sender, EventArgs e)
        {
            
       
            
            if (Chassis_no.MaxLength == count)
            {
                Chassis_no.ReadOnly = true;
               
                
               
            }
            count = 1 + count;
        
        }
    }
}