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
    public partial class NormalUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void done_Click(object sender, EventArgs e)
        {
        
                String fname = teamname.Text;
                String lname = comname.Text;
                String birth = formation.Text;

                var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
                using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Updatemyinformationnormal", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Login.Oldmember == true)
                    {
                        String email = Login.Username;
                        cmd.Parameters.Add(new SqlParameter("@email", email));
                    }
                    else
                    {

                        String email = NormalUser.Email;
                        cmd.Parameters.Add(new SqlParameter("@email", email));

                    }

                    cmd.Parameters.Add(new SqlParameter("@fname", fname));
                    cmd.Parameters.Add(new SqlParameter("@lname", lname));
                    cmd.Parameters.Add(new SqlParameter("@birth", birth));


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    conn.Close();

                }
                Response.Redirect("GamersNetwork.aspx");
            }
    }
}