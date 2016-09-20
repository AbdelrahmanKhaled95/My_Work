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
    public partial class DevelopUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void done_Click(object sender, EventArgs e)
        {
           

                String tn = teamname.Text;
                String comn = comname.Text;
                String age = formation.Text;

                var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
                using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Updatemyinformationdevelplment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Login.Oldmember == true)
                    {
                        String email = Login.Username;
                        cmd.Parameters.Add(new SqlParameter("@mail", email));
                    }
                    else
                    {

                        String email = DevelopmentTeam.Email;
                        cmd.Parameters.Add(new SqlParameter("@mail", email));

                    }

                    cmd.Parameters.Add(new SqlParameter("@team", tn));
                    cmd.Parameters.Add(new SqlParameter("@company", comn));
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