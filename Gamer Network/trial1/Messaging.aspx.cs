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
    public partial class Messaging : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("My_thread_messages", dbconnection);
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
                String recevier = Inbox.Emailfriend;
                cmd.Parameters.Add(new SqlParameter("@email", recevier));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    gv.DataSource = dataSet;

                    gv.DataBind();

                }
            }
        }

        protected void send_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                dbconnection.Open();
                SqlCommand cmd = new SqlCommand("sendandrecieve", dbconnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Login.Oldmember == true)
                {
                    String email = Login.Username;
                    cmd.Parameters.Add(new SqlParameter("@emailsender", email));
                }
                else
                {

                    String email = NormalUser.Email;
                    cmd.Parameters.Add(new SqlParameter("@emailsender", email));

                }

                String recevier = Inbox.Emailfriend;
                String content = TextBox1.Text;
                DateTime now = DateTime.Now;
                cmd.Parameters.Add(new SqlParameter("@emailreciever", recevier));
                cmd.Parameters.Add(new SqlParameter("@content", content));
                cmd.Parameters.Add(new SqlParameter("@date", now));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
            }
            Response.Redirect("Messaging");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamersNetwork");
        }
    }
}