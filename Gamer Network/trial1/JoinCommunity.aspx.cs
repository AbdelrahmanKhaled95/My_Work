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
    public partial class JoinCommunity : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
                using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from Communities", conn);

                    conn.Open();
                    DropDownList1.DataTextField = "Theme";
                    DropDownList1.DataValueField = "Theme";
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataBind();
                    conn.Close();
                    ListItem m = new ListItem("Select Community", "-1");
                    DropDownList1.Items.Insert(0, m);
                }
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
             using (SqlConnection conn = new SqlConnection(connectionfromconfiguration.ConnectionString))
             {
                 SqlCommand cmd = new SqlCommand("joinCommunity", conn);
                 cmd.CommandType = CommandType.StoredProcedure;

                 string theme = DropDownList1.SelectedItem.Value;
                 string mail = lblmail.Text;

                 cmd.Parameters.Add(new SqlParameter("@name", mail));
                 cmd.Parameters.Add(new SqlParameter("@theme", theme));
                 SqlParameter output = cmd.Parameters.Add("@out", SqlDbType.Int);
                 output.Direction = ParameterDirection.ReturnValue;


                 conn.Open();
                 cmd.ExecuteNonQuery();
                 conn.Close();


                 if (output.Value.ToString().Equals("1"))
                 {
                     Label2.Text = "you joinned this community successfully";
                 }
                 else
                 {
                     Label2.Text = "you had been added to this community before !";
                 }



                 //conn.Close();

             }
        }
    }
}