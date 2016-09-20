using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trial1
{
    public partial class DevelopmentTeam : System.Web.UI.Page
    {
        private static String email;

        public static String Email
        {
            get { return DevelopmentTeam.email; }
            set { DevelopmentTeam.email = value; }
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void done_Click(object sender, EventArgs e)
        {
             email = emailbox.Text;
            String tn = teamname.Text;
            String comn = comname.Text;
            String age = formation.Text;
            
            String pass = passBox.Text;
            String genre = genres.SelectedValue;


            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd3 = new SqlCommand("loginproc", conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                String username = emailbox.Text;
                string password = passBox.Text;
                cmd3.Parameters.Add(new SqlParameter("@email", username));

                // output parm
                SqlParameter count3 = cmd3.Parameters.Add("@count", SqlDbType.Int);
                count3.Direction = ParameterDirection.Output;
                conn.Open();
                cmd3.ExecuteNonQuery();

                int x = Int32.Parse(cmd3.Parameters["@count"].Value.ToString());
                if (x == 1)
                {
                    Response.Redirect("Error");

                }

                SqlCommand cmd2 = new SqlCommand("signUp1", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@email", email));
                cmd2.Parameters.Add(new SqlParameter("@password", pass));
                cmd2.Parameters.Add(new SqlParameter("@preferredgame", genre));
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
                DataSet dataSet2 = new DataSet();
                dataAdapter2.Fill(dataSet2);
                SqlCommand cmd = new SqlCommand("insertDevelopmentTeam", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@name", tn));
                cmd.Parameters.Add(new SqlParameter("@company ", comn));
                cmd.Parameters.Add(new SqlParameter("@date", age));


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                conn.Close();

            }
            Response.Redirect("GamersNetworkdevelop.aspx"); 
        }
    }
}