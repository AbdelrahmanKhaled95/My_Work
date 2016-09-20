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
    public partial class CommentReviews : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("myconnection", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String email = Login.Username;
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
        protected void gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gv.Rows[e.RowIndex].Cells[0];
            int comment = int.Parse(cell.Text);
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("deletecomment", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@comment", comment));
                dbconnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gv.EditIndex = -1;
                binddatatogridview();
                dbconnection.Close();
            }


        }
    }
}