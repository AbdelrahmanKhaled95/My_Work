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
    public partial class ReviewsConference : System.Web.UI.Page
    {
        private static int conf_id;

        public static int Conid
        {
            get { return conf_id; }
            set {  ReviewsConference.conf_id = value; }
        }
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

            SqlCommand cmd = new SqlCommand("conreviews", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@conf_id", Conference.No));
            conn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                gv.DataSource = dataSet;

                gv.DataBind();

            }

        }
        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            binddatatogridview();
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            binddatatogridview();
        }

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvrow = (GridViewRow)gv.Rows[e.RowIndex];
            TextBox t = (TextBox)gvrow.Cells[1].Controls[0];
            TextBox t1 = (TextBox)gvrow.Cells[2].Controls[0];
            int conf_id = int.Parse(t.Text);
            int conf_rev_id = int.Parse(t1.Text);
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("ADDcommconfrence", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String name = Login.Username;
                    cmd.Parameters.Add(new SqlParameter("@email", name));
                }
                else
                {
                    if (Signup.Normalu == true)
                    {
                        String name = NormalUser.Email;
                        cmd.Parameters.Add(new SqlParameter("@email", name));
                    }
                    else if (Signup.Verifiedu == true)
                    {
                        String name = VerifiedReviewer.Email;
                        cmd.Parameters.Add(new SqlParameter("@email", name));
                    }
                    else if (Signup.Develop == true)
                    {
                        String name = DevelopmentTeam.Email;
                        cmd.Parameters.Add(new SqlParameter("@email", name));
                    }
                }
                String comment = content.Text;
                cmd.Parameters.Add(new SqlParameter("@con_id", conf_id));
                cmd.Parameters.Add(new SqlParameter("@con_review_id", conf_rev_id));
                cmd.Parameters.Add(new SqlParameter("@content", comment));

                Response.Redirect("ReviewsConference");

            }
        }
    }
}