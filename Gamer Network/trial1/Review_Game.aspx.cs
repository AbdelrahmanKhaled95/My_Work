using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
namespace trial1
{
    public partial class Review_Game : System.Web.UI.Page
    {
        String x = "";
        String gamename = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["Start"] != null)
                lblemail.Text = Request.Cookies["Start"].Value;
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

                Page pp = Page.PreviousPage;
                if (pp != null)
                {
                    lblemail.Text = ((Label)pp.FindControl("Label3")).Text;
                }
                // x =Convert.ToInt32(Label1.Text);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection dbconnection = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {

                SqlConnection con = new SqlConnection("Data Source=ENYAHYA;Initial Catalog=Project;Integrated Security=True");
                SqlCommand da = new SqlCommand("addgamereview", con);
                da.CommandType = CommandType.StoredProcedure;

                da.Parameters.Add(new SqlParameter("@content", TextBox1.Text));
                da.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                da.Parameters.Add(new SqlParameter("@game_id", DropDownList1.SelectedItem.Value));
                da.Parameters.Add(new SqlParameter("@verified_reviewer", lblemail.Text));
                SqlParameter count = da.Parameters.Add("@inserted", SqlDbType.Int);
                count.Direction = ParameterDirection.Output;

                con.Open();
                da.ExecuteNonQuery();
                con.Close();

                if (count.Value.ToString().Equals("0"))
                {
                    Label3.Text = "Only verified reviewers are allowed to post reviews";
                }
                else
                {
                    Label3.Text = "Review posted successfully";
                }

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}