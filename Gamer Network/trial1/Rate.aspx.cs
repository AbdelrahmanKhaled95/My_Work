using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace trial1
{
    public partial class Rate : System.Web.UI.Page
    {
        String x = "";
        String name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Login.Oldmember == true)
                name = Login.Username;
            else if (Signup.Normalu == true)
                name = NormalUser.Email;
            else if (Signup.Verifiedu == true)
                name = VerifiedReviewer.Email;
            else name = DevelopmentTeam.Email;
            if (Request.Cookies["Start"] != null)
                x = Request.Cookies["Start"].Value;

            Page pp = Page.PreviousPage;
            if (pp != null)
            {
                name = (pp.FindControl("Label3")).ToString();
            }

            if (!IsPostBack)
            {
                var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
                using (SqlConnection con = new SqlConnection(connectionfromconfiguration.ConnectionString))
                {
                    SqlCommand da = new SqlCommand("Select * From Games ", con);
                    con.Open();
                    DropDownList1.DataTextField = "name";
                    DropDownList1.DataValueField = "game_id";
                    DropDownList1.DataSource = da.ExecuteReader();
                    DropDownList1.DataBind();
                    con.Close();

                    ListItem y = new ListItem("Select Game", "-1");
                    DropDownList1.Items.Insert(0, y);

                    DataSet ds1 = new DataSet();
                    //da.Fill(ds1);
                   // GridView1.DataSource = ds1;
                    //GridView1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = Start.Mail;
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection con = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                
                SqlCommand da = new SqlCommand("rateGame", con);
                da.CommandType = CommandType.StoredProcedure;

                int graphics = int.Parse(TextBox1.Text);
                int inter = Convert.ToInt32(TextBox2.Text.ToString());
                int unique = Convert.ToInt32(TextBox3.Text.ToString());
                int design = Convert.ToInt32(TextBox4.Text.ToString());

                da.Parameters.Add(new SqlParameter("@graphics", graphics));
                da.Parameters.Add(new SqlParameter("@interactivity", inter));
                da.Parameters.Add(new SqlParameter("@uniquness", unique));
                da.Parameters.Add(new SqlParameter("@level", design));
                da.Parameters.Add(new SqlParameter("@member", m));
                da.Parameters.Add(new SqlParameter("@game", DropDownList1.SelectedItem.Value));

                con.Open();
                da.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}