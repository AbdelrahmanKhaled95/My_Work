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
    public partial class Add_Confeerence : System.Web.UI.Page
    {
        private static int id;

        public static int Id
        {
            get { return Add_Confeerence.id; }
            set { Add_Confeerence.id = value; }
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

            SqlCommand cmd = new SqlCommand("conf", conn);
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

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            binddatatogridview();
        }

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvrow = (GridViewRow)gv.Rows[e.RowIndex];
            TextBox t = (TextBox)gvrow.Cells[1].Controls[0];
            String id = t.Text;
            int id2 = Int32.Parse(id);

            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("insertConferenceAttend", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String email = Login.Username;
                    cmd.Parameters.Add(new SqlParameter("@email", email));
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
                cmd.Parameters.Add(new SqlParameter("@conf", id2));
                dbconnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gv.EditIndex = -1;
                binddatatogridview();
                dbconnection.Close();

                Response.Redirect("Add Confeerence");
            }
        }

        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            binddatatogridview();
        }
    }
}