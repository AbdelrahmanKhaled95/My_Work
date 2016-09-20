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
    public partial class Hardness_Report : Form
    {
        public Hardness_Report()
        {
            InitializeComponent();
            Report report = new Report();
            ConnectionString = " Data Source=10.10.11.54,1455;Initial Catalog=SFDB_Sadat_AG_Test_2-6-2016_2;Persist Security Info=True;User ID=vendorAG;Password=vendor@01";
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlCommand cmd = new SqlCommand("last102", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@from", report.getDate()));
            cmd.Parameters.Add(new SqlParameter("@to", report.getDateTimePicker1()));
            dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            Conn.Close();
        }

        private void Details_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Report main = new Report();
            main.Show();
        }
        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        DataTable dt;
        private void Details_Click(object sender, EventArgs e)
        {
           
        }

        private void Hardness_Report_Load(object sender, EventArgs e)
        {

        }
    }
}