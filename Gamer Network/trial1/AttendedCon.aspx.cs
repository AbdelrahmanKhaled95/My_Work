using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trial1
{
    public partial class AttendedCon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                binddatatogridview();
            }


        }

        private void binddatatogridview()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Team"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("mycon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (Login.Oldmember == true)
            {
                String name = Login.Username;
                cmd.Parameters.Add(new SqlParameter("@me", name));
            }
            else
            {
                if (Signup.Normalu == true) { 
                   String name =  NormalUser.Email;
                cmd.Parameters.Add(new SqlParameter("@me", name));
            }
                else if (Signup.Verifiedu == true)
                {
                    String name = VerifiedReviewer.Email;
                    cmd.Parameters.Add(new SqlParameter("@me", name));
                }
                else if (Signup.Develop == true)
                {
                    String name = DevelopmentTeam.Email;
                    cmd.Parameters.Add(new SqlParameter("@me", name));
                }
            }
            
            

            conn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                gv1.DataSource = dataSet;

                gv1.DataBind();

            }

        }
    }
}