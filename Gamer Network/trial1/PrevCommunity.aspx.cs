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
    public partial class PrevCommunity : System.Web.UI.Page
    {
      
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

          


            Page prevPage = Page.PreviousPage;
            if (prevPage != null)
                lblmail.Text = ((Label)prevPage.FindControl("lblmail")).Text;




            if (IsPostBack == false)
            {
                var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
                using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
                {
                    SqlCommand cm = new SqlCommand("select * from Communities", conn);
                    conn.Open();
                    DropDownList2.DataTextField = "Theme";
                    DropDownList2.DataValueField = "Theme";
                    DropDownList2.DataSource = cm.ExecuteReader();
                    DropDownList2.DataBind();
                    conn.Close();
                    Label6.Visible = false;
                    Label7.Visible = false;
                    txttitle.Visible = false;
                    txtdesc.Visible = false;
                    Button2.Visible = false;
                    DropDownList3.Enabled = false;
                    ListItem m = new ListItem("Select Community", "-1");
                    DropDownList2.Items.Insert(0, m);



                }
            }

           
           
          
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cm = new SqlCommand("checkjoinned", conn);
                cm.CommandType = CommandType.StoredProcedure;

                string theme = DropDownList2.SelectedItem.Value.ToString();
                string mail = lblmail.Text;

                cm.Parameters.Add(new SqlParameter("@theme", theme));
                cm.Parameters.Add(new SqlParameter("@email", mail));
                SqlParameter output = cm.Parameters.Add("@out", SqlDbType.Int);
                output.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();

                if (output.Value.ToString().Equals("1"))
                {
                    SqlCommand cmd = new SqlCommand("postTopic", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Title", txttitle.Text));
                    cmd.Parameters.Add(new SqlParameter("@description_text", txtdesc.Text));
                    cmd.Parameters.Add(new SqlParameter("@theme", theme));
                    cmd.Parameters.Add(new SqlParameter("@email", mail));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    lbladd.Text = "Your topic is posted";

                }
                else
                {
                    lbladd.Text = "You are not a member of this community";
                }
                GridView1.DataBind();
                drop3();
                //DropDownList3.DataBind();
            }
        }



        protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
        {

            lbladd.Text = "";
            lbldelete.Text = "";

            HttpCookie cookie = new HttpCookie("PrevCommunity");
            cookie.Value = DropDownList2.SelectedItem.Value.ToString() + "," + lblmail.Text;
            Response.Cookies.Add(cookie);


            DropDownList3.Enabled = true;
            Label6.Visible = true;
            Label7.Visible = true;
            txttitle.Visible = true;
            txtdesc.Visible = true;
            Button2.Visible = true;

            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("getcomm", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                lbltheme.Text = DropDownList2.SelectedItem.Value.ToString();

                cmd.Parameters.Add(new SqlParameter("@theme", lbltheme.Text));
                SqlParameter name = cmd.Parameters.Add("@name", SqlDbType.VarChar, 30);
                name.Direction = ParameterDirection.Output;
                SqlParameter des = cmd.Parameters.Add("@des", SqlDbType.VarChar, 100);
                des.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                lblname.Text = name.Value.ToString();
                lbldesc.Text = des.Value.ToString();




                drop3();



                //ListItem m = new ListItem("Select topic", "-1");
                //DropDownList3.Items.Insert(0, m);

                if (GridView1.SelectedRow != null)
                {
                    Server.Transfer("~/Page2.aspx");
                }

            }
        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cm = new SqlCommand("deleteTopic", conn);
                cm.CommandType = CommandType.StoredProcedure;


                string s = lblmail.Text;

                cm.Parameters.Add(new SqlParameter("@email", s));
                cm.Parameters.Add(new SqlParameter("@theme", DropDownList2.SelectedItem.Value));
                cm.Parameters.Add(new SqlParameter("@Topic_id", DropDownList3.SelectedItem.Value));

                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
                GridView1.DataBind();
                //DropDownList3.DataBind();
                drop3();

                lbldelete.Text = "this topic is deleted successfully";
            }
        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        public void drop3()
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand cmm = new SqlCommand("gettopic", conn);
                cmm.CommandType = CommandType.StoredProcedure;


                string s = lblmail.Text;
                cmm.Parameters.Add(new SqlParameter("@theme", DropDownList2.SelectedItem.Value));
                cmm.Parameters.Add(new SqlParameter("@mail", s));


                conn.Open();
                DropDownList3.DataTextField = "Title";
                DropDownList3.DataValueField = "topic_id";
                DropDownList3.DataSource = cmm.ExecuteReader();
                DropDownList3.DataBind();
                conn.Close();
                ListItem m = new ListItem("Select Topic", "-1");
                DropDownList3.Items.Insert(0, m);
            }

        }
       


    }
}