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
    public partial class MypendingFriends : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("Pending_friends", dbconnection);
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


        protected void gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            TableCell cell = gv.Rows[e.RowIndex].Cells[2];
            String email2 = cell.Text;

            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Reject", dbconnection);
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
                cmd.Parameters.Add(new SqlParameter("@normal2", email2));
                dbconnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gv.EditIndex = -1;
                binddatatogridview();
                dbconnection.Close();
                Response.Redirect("MypendingFriends");
            }
        }

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            
            GridViewRow gvrow = (GridViewRow)gv.Rows[e.RowIndex];
            TextBox t = (TextBox)gvrow.Cells[2].Controls[0];
            String email2 = t.Text;
            
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Accept", dbconnection);
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
                cmd.Parameters.Add(new SqlParameter("@normal2", email2));
                dbconnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gv.EditIndex = -1;
                binddatatogridview();
                dbconnection.Close();
                
                Response.Redirect("MypendingFriends");
            }
            }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            binddatatogridview();
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamersNetwork");
        }

        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            binddatatogridview();
        }
        
    }
}