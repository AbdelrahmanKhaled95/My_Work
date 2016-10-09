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
    public partial class thickness_Report : Form
    {
        public thickness_Report()
        {
            InitializeComponent();
            Main main=new Main();
            Server server = new Server();
            ConnectionString = server.getServer();
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlCommand cmd = new SqlCommand("last101", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@from", ""));
            cmd.Parameters.Add(new SqlParameter("@to", ""));
            dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            Conn.Close();
        }
        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        DataTable dt;
        private void Summary_Click(object sender, EventArgs e)
        {
            Thickness_summary summary= new Thickness_summary();
            summary.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main=new Main();
            main.Show();
            this.Hide();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            thicknessCrystal thC = new thicknessCrystal();
            thC.Show();
            this.Hide();
        }
    }
}
