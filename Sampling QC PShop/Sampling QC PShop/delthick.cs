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
    public partial class delthick : Form
    {
        public delthick()
        {
            InitializeComponent();
        }
        public static SqlConnection Conn;
        private static string ConnectionString = string.Empty;
        DataTable dt;
        private void delete_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            ConnectionString = server.getServer();
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;

            Conn.Open();
            SqlCommand cmd = new SqlCommand("[dbo].[upd1]", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@chassis_no", textBox1.Text));

            SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
            count.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int x = Int32.Parse(cmd.Parameters["@count"].Value.ToString());

            if (x == 1)
            {

                ConnectionString = server.getServer();
                Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;

                Conn.Open();
                SqlCommand cmd2 = new SqlCommand("[dbo].[undo1]", Conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                cmd2.Parameters.Add(new SqlParameter("@chassis_no", textBox1.Text));
                cmd2.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("تم مسح الشاسية بنجاح ");

            }
            else
            {
                MessageBox.Show("هذا الشاسية غير موجود");
            }
        }
    

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.Show();
             
        }
}
    }