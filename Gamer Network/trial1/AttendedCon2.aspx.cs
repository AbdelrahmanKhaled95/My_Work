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
    public partial class AttendedCon2 : System.Web.UI.Page
    {
        private static int id;
        public static int Id
        {
            get { return AttendedCon2.id; }
            set { AttendedCon2.id = value; }
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

            SqlCommand cmd = new SqlCommand("mycon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (Login.Oldmember == true)
            {
                String name = Login.Username;
                cmd.Parameters.Add(new SqlParameter("@me", name));
            }
            else
            {
                if (Signup.Normalu == true)
                {
                    String name = NormalUser.Email;
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
                gv2.DataSource = dataSet;

                gv2.DataBind();

            }

        }

        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv2.EditIndex = -1;
            binddatatogridview();
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv2.EditIndex = e.NewEditIndex;
            binddatatogridview();
        }

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvrow = (GridViewRow)gv2.Rows[e.RowIndex];
            TextBox t = (TextBox)gvrow.Cells[1].Controls[0];
            

            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("ConferenceReview", dbconnection);
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
                    String title = t.Text;
                    String content = c.Text;
                    String date = d.Text;

                    cmd.Parameters.Add(new SqlParameter("@title", title));
                    cmd.Parameters.Add(new SqlParameter("@contents", content));
                    cmd.Parameters.Add(new SqlParameter("@date", date));
                }


            }

        }
    }

}