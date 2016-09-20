using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace trial1
{
    public partial class Start : System.Web.UI.Page
    {
        private static string mail;
        
        public static string Mail
        {
            get { return Start.mail; }
            set { Start.mail = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Login.Oldmember == true)
                mail = Login.Username;
            else if (Signup.Normalu == true)
                mail = NormalUser.Email;
            else if (Signup.Verifiedu == true)
                mail = VerifiedReviewer.Email;
            else mail = DevelopmentTeam.Email;
     
            //label text should be equal to the email of the user
            HttpCookie c = new HttpCookie("Start");
            c.Value = label.Text;
            Response.Cookies.Add(c); 
            
             label.Text=mail;
            if (!IsPostBack)
            {
              /*  string ProjectDBcs = ConfigurationManager.ConnectionStrings["ProjectDB"].ConnectionString;

                SqlConnection con = new SqlConnection(ProjectDBcs);
                SqlCommand da = new SqlCommand("Select * From Games ", con);
                con.Open();
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "name";
                DropDownList1.DataSource = da.ExecuteReader();
                DropDownList1.DataBind();
                con.Close();

                ListItem y = new ListItem("Select Game", "-1");
                DropDownList1.Items.Insert(0, y);*/

               //DataSet ds1 = new DataSet();
               //da.Fill(ds1);
               //GridView1.DataSource = ds1;
               //GridView1.DataBind();
            }
        }

     

       /* protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Label1.Text = DropDownList1.SelectedValue;
            HttpCookie c = new HttpCookie("Start");
            c.Value = DropDownList1.SelectedItem.Value;
            Response.Cookies.Add(c); 

        
        }*/

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

    }
}