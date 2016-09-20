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
    public partial class VerifiedReviewers_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                binddatatogridview();
        }

        private void binddatatogridview()
        {

            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {

                dbconnection.Open();
                SqlCommand cmd = new SqlCommand("searchVerifiedReviewerall", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
              if(Login.Iamnormaluser==true){
                  String email=GamersNetwork.Find;
                  cmd.Parameters.Add(new SqlParameter("@email", email));
              }
              else
                  if(Login.Iamdevelop==true){
                      String email=GamersNetworkdevelop.Find;

                      cmd.Parameters.Add(new SqlParameter("@email", email));
              }
                else{
                    String email=GamersNetworkverified.Find;

                    cmd.Parameters.Add(new SqlParameter("@email", email));
                }
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    gv.DataSource = dataSet;

                    gv.DataBind();

                }
                dbconnection.Close();
            }
        }
    }
}