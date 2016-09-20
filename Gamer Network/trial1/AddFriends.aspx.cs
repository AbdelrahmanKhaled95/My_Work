using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trial1
{
    public partial class AddFriends : System.Web.UI.Page
    {
        private static int x;
        private static List<string> array = new List<string>();

 protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                binddatatogridview();
            }
              

        }

        private void binddatatogridview()
        {

            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {

                dbconnection.Open();
                SqlCommand cmd = new SqlCommand("Search_the_members", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String email = Login.Username;
                    cmd.Parameters.Add(new SqlParameter("@me", email));
                }
                else
                {
                  

                    String email = NormalUser.Email;
                    cmd.Parameters.Add(new SqlParameter("@me", email));

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


        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvrow = (GridViewRow)gv.Rows[e.RowIndex];
            TextBox t = (TextBox)gvrow.Cells[0].Controls[0];
            String email2 = t.Text;
            array.Add(email2);
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Send_friendship_requests", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String email = Login.Username;
                    cmd.Parameters.Add(new SqlParameter("@me", email));
                }
                else
                {

                    String email = NormalUser.Email;
                    cmd.Parameters.Add(new SqlParameter("@me", email));

                }
                cmd.Parameters.Add(new SqlParameter("@email", email2));
                dbconnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gv.EditIndex = -1;
                binddatatogridview();
                dbconnection.Close();
                Response.Redirect("AddFriends");
            }
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            binddatatogridview();
        }

       
        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            binddatatogridview();
        }
        protected void count()
        {

            string connStr = ConfigurationManager.ConnectionStrings["Team"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("countmembers", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            // output parm
            SqlParameter count = cmd.Parameters.Add("@number", SqlDbType.Int);
            count.Direction = ParameterDirection.Output;
            conn.Open();
            cmd.ExecuteNonQuery();
             x = Int32.Parse(cmd.Parameters["@count"].Value.ToString());
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamersNetwork");
        }


    }
}