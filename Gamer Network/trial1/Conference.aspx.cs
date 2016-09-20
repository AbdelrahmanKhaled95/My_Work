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
    public partial class Conference : System.Web.UI.Page
    {
        private static int no;

        public static int No
        {
            get { return Conference.no; }
            set { Conference.no = value; }
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

            SqlCommand cmd = new SqlCommand("conferenceView", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if(Login.Oldmember==true){
                if(Login.Iamdevelop==true){
                     String name = GamersNetworkdevelop.Find;
                 cmd.Parameters.Add(new SqlParameter("@con_id", name));
                }
                else if(Login.Iamnormaluser==true){
                     String name = GamersNetwork.Find;
                 cmd.Parameters.Add(new SqlParameter("@con_id", name));
                }
                else{
                    String name = GamersNetworkverified.Find;
                 cmd.Parameters.Add(new SqlParameter("@con_id", name));
                }
            }

            else{
                if(Signup.Normalu==true){
                    String name = GamersNetwork.Find;
                 cmd.Parameters.Add(new SqlParameter("@con_id", name));
            }
                else if(Signup.Develop==true){
                    String name = GamersNetworkdevelop.Find;
                 cmd.Parameters.Add(new SqlParameter("@con_id", name));
                }

                else{
                    String name = GamersNetworkverified.Find;
                 cmd.Parameters.Add(new SqlParameter("@con_id", name));
                }

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
            String s = t.Text;
            no = Int32.Parse(s);
            Response.Redirect("reviewsConference");
        }

       
    }
}