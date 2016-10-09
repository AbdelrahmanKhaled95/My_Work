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
    public partial class Adhesion_Report : Form
    {
        
        public Adhesion_Report()
        {
            InitializeComponent();
            Report report = new Report();
            Server server = new Server();
            ConnectionString = server.getServer();
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlCommand cmd = new SqlCommand("last104", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            cmd.Parameters.Add(new SqlParameter("@from",report.getFrom() ));
            cmd.Parameters.Add(new SqlParameter("@to", report.getTo()));
            dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            Conn.Close();
        }

        private void Details_Click_1(object sender, EventArgs e)
        {

        }

        private void Back_Click_1(object sender, EventArgs e)
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

        private void Details_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}