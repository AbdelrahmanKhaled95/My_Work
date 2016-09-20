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
    public partial class Inbox : System.Web.UI.Page
    {
        private static String emailfriend;

        public static String Emailfriend
        {
            get { return Inbox.emailfriend; }
            set { Inbox.emailfriend = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                binddatatogridview();
        }

        private void binddatatogridview()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Team"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("myfriends2", conn);
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

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvrow = (GridViewRow)gv.Rows[e.RowIndex];
            TextBox t = (TextBox)gvrow.Cells[2].Controls[0];
            emailfriend = t.Text;
           Response.Redirect("Messaging");
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            binddatatogridview();
        }
      
    }
}