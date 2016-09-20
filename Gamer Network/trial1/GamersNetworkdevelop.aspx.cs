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
    public partial class GamersNetworkdevelop : System.Web.UI.Page
    {
        private static String find;

        public static String Find
        {
            get { return GamersNetworkdevelop.find; }
            set { GamersNetworkdevelop.find = value; }
        }

     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { 
                binddatatogridview();
            }
           
            }


        private void binddatatogridview()
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("findmedevelop", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String email = Login.Username;
                    cmd2.Parameters.Add(new SqlParameter("@email",email));
                }
                else
                {

                    String email = DevelopmentTeam.Email;
                    cmd2.Parameters.Add(new SqlParameter("@email", email));

                }
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
                DataSet dataSet2 = new DataSet();
                dataAdapter2.Fill(dataSet2);
                if (dataSet2.Tables[0].Rows.Count > 0)
                {
                    gv.DataSource = dataSet2;

                    gv.DataBind();

                }
            }
        }

 

        protected void updateme_Click(object sender, EventArgs e)
        {
            Response.Redirect("DevelopUpdate.aspx");
        }

        protected void searchbtn_Click(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["Team"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("searchGame", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            find = search.Text;

            cmd.Parameters.Add(new SqlParameter("@name", find));

            // output parm
            SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
            count.Direction = ParameterDirection.Output;
            conn.Open();
            cmd.ExecuteNonQuery();

            int x = Int32.Parse(cmd.Parameters["@count"].Value.ToString());
            if (x == 1)
            {
                Response.Redirect("Games");

            }
            ///////////////////////////////////////////////////////////////////////
            SqlCommand cmd2 = new SqlCommand("searchConference", conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            find = search.Text;
            cmd2.Parameters.Add(new SqlParameter("@name", find));

            // output parm
            SqlParameter count2 = cmd2.Parameters.Add("@count", SqlDbType.Int);
            count2.Direction = ParameterDirection.Output;

            cmd2.ExecuteNonQuery();

            int x2 = Int32.Parse(cmd2.Parameters["@count"].Value.ToString());
            if (x2 == 1)
            {
                Response.Redirect("Conference");

            }
            ////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////
            SqlCommand cmd4 = new SqlCommand("searchVerifiedReviewer", conn);
            cmd4.CommandType = CommandType.StoredProcedure;
            find = search.Text;
            cmd4.Parameters.Add(new SqlParameter("@email", find));

            // output parm
            SqlParameter count4 = cmd4.Parameters.Add("@count", SqlDbType.Int);
            count4.Direction = ParameterDirection.Output;

            cmd4.ExecuteNonQuery();

            int x4 = Int32.Parse(cmd4.Parameters["@count"].Value.ToString());
            if (x4 == 1)
            {
                Response.Redirect("VerifiedReviewers info");

            }
            //////////////////////////////////////////////////////////////////////////

            SqlCommand cmd5 = new SqlCommand("searchDevelopmentTeam", conn);
            cmd5.CommandType = CommandType.StoredProcedure;
            find = search.Text;
            cmd5.Parameters.Add(new SqlParameter("@email", find));

            // output parm
            SqlParameter count5 = cmd5.Parameters.Add("@count", SqlDbType.Int);
            count4.Direction = ParameterDirection.Output;

            cmd5.ExecuteNonQuery();

            int x5 = Int32.Parse(cmd5.Parameters["@count"].Value.ToString());
            if (x5 == 1)
            {
                Response.Redirect("DevelopmentTeaminfo");

            }




        }

        protected void com_Click(object sender, EventArgs e)
        {
            Response.Redirect("Community");
        }

        protected void conferences_Click(object sender, EventArgs e)
        {
            Response.Redirect("AttendedCon");
        }

        protected void games_Click(object sender, EventArgs e)
        {

        }

        protected void addgame_Click(object sender, EventArgs e)
        {
            Response.Redirect("developnewgame");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login");
        }

        protected void attend_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add Confeerence");
        }

        protected void conrew_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReviewsConference");
        }

        protected void reviewcomments_Click(object sender, EventArgs e)
        {
            Response.Redirect("CommentReviews");
        }

        protected void viewcon_Click(object sender, EventArgs e)
        {
            Response.Redirect("AttendedCon2");
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Response.Redirect("CommentReviews");
        }
    }

}
