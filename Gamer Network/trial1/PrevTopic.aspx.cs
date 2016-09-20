using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace trial1
{
    public partial class prevTopic : System.Web.UI.Page
    {
        string theme = "";
        string mail = "";
        int topic = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "";
            if (Login.Oldmember = true)
                name = Login.Username;
            else if (Signup.Normalu == true)
                name = NormalUser.Email;
            else if (Signup.Verifiedu == true)
                name = VerifiedReviewer.Email;
            else name = DevelopmentTeam.Email;

            lblmail.Text = name;

            

            string s = Request.QueryString["topic_id"];
            string w="";

            if (Request.Cookies["PrevCommunity"] != null)
                w=Request.Cookies["PrevCommunity"].Value;

            string[] stringSeparators = new string[] { "," };
            string[] t = w.Split(stringSeparators,StringSplitOptions.RemoveEmptyEntries);
            lblmail.Text = t[1];

            mail = t[1];
            theme = t[0];

             var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
             using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
             {
                 SqlCommand cmd = new SqlCommand("changetype", conn);
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.Add(new SqlParameter("@t", s));
                 SqlParameter r = cmd.Parameters.Add("@r", SqlDbType.Int);
                 r.Direction = ParameterDirection.ReturnValue;


                 conn.Open();
                 cmd.ExecuteNonQuery();
                 conn.Close();

                 int k = Int32.Parse(r.Value.ToString());
                 topic = k;
             
            
                SqlCommand cm = new SqlCommand("getdesc", conn);
                cm.CommandType = CommandType.StoredProcedure;


                cm.Parameters.Add(new SqlParameter("@topic", k));
                SqlParameter title = cm.Parameters.Add("@title", SqlDbType.VarChar, 50);
                title.Direction = ParameterDirection.Output;
                SqlParameter des = cm.Parameters.Add("@des", SqlDbType.VarChar, 50);
                des.Direction = ParameterDirection.Output;


                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();

                lbltopic.Text = title.Value.ToString();
                lbldesc.Text = des.Value.ToString();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cm = new SqlCommand("ADDcomTopic", conn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.Add(new SqlParameter("@content", txtcomment.Text));
                cm.Parameters.Add(new SqlParameter("@date_of_comment", DateTime.Now));
                cm.Parameters.Add(new SqlParameter("@theme", theme));
                cm.Parameters.Add(new SqlParameter("@topic_id", topic));
                cm.Parameters.Add(new SqlParameter("@me", mail));


                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();

                lblmsg.Text = "Your comment is added succesfully";
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
            
            GridViewRow row =GridView1.SelectedRow;
            if (row==null)
            {
                lbldel.Text = "Please select comment to delete";
                return;
            }
            string s =row.Cells[3].Text;
            
       

            if (s.Equals(mail))
            {
                 
                SqlCommand cm = new SqlCommand("deletecomment", conn);
                cm.CommandType = CommandType.StoredProcedure;

                int k = Int32.Parse(row.Cells[4].Text.ToString());
                cm.Parameters.Add(new SqlParameter("@id", k));

                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
                GridView1.DataBind();

            }
            else 
            {
                lbldel.Text = "You are not allowed to delete this comment";
            }
            }
        }
    }
}