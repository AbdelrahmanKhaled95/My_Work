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
    public partial class Thickness_summary : Form
    {
        public Thickness_summary()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Thickness_Report back = new Thickness_Report();
            back.Show();
             ;
        }
        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        DataTable dt;
        private void max_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            ConnectionString = server.getServer();
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  Count(Chassis_no) as count,max(Fender_Rf)as Fender_Rf,max(Fender_Lf) as Fender_Lf,max(Door_Rf) as Door_Rf,max(Door_Lf) as Door_Lf,max(Fender_Rr) as Fender_Rr,max(Fender_Lr) as Fender_Lr,max(Door_Rr) as Door_Rr,max(Door_Lr) as Door_Lr,max(Hood) as Hood,max(Roof) as Roof,max(Truck_lid)as Truck_lid FROM [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Thickness_PCQ]   ", Conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            Conn.Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            ConnectionString = " Data Source=10.10.11.54,1455;Initial Catalog=SFDB_Sadat_AG_Test_2-6-2016_2;Persist Security Info=True;User ID=vendorAG;Password=vendor@01";
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  Count(Chassis_no) as count,min(Fender_Rf)as Fender_Rf,min(Fender_Lf) as Fender_Lf,min(Door_Rf) as Door_Rf,min(Door_Lf) as Door_Lf,min(Fender_Rr) as Fender_Rr,min(Fender_Lr) as Fender_Lr,min(Door_Rr) as Door_Rr,min(Door_Lr) as Door_Lr,min(Hood) as Hood,min(Roof) as Roof,min(Truck_lid)as Truck_lid FROM [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Thickness_PCQ]   ", Conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            Conn.Close();
        }

        private void avg_Click(object sender, EventArgs e)
        {
            ConnectionString = " Data Source=10.10.11.54,1455;Initial Catalog=SFDB_Sadat_AG_Test_2-6-2016_2;Persist Security Info=True;User ID=vendorAG;Password=vendor@01";
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  Count(Chassis_no) as count,avg(Fender_Rf)as Fender_Rf,avg(Fender_Lf) as Fender_Lf,avg(Door_Rf) as Door_Rf,avg(Door_Lf) as Door_Lf,avg(Fender_Rr) as Fender_Rr,avg(Fender_Lr) as Fender_Lr,avg(Door_Rr) as Door_Rr,avg(Door_Lr) as Door_Lr,avg(Hood) as Hood,avg(Roof) as Roof,avg(Truck_lid)as Truck_lid FROM [SFDB_Sadat_AG_Test_2-6-2016_2].[dbo].[Thickness_PCQ]   ", Conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            Conn.Close();
        }
    }
}