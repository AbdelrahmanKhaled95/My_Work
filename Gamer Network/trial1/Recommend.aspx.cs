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
    public partial class Recommend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text= Start.Mail;
           // Page pp = Page.PreviousPage;
          //  if (pp != null)
            //{
             //   Label1.Text = ((Label)pp.FindControl("label")).Text;
            //}
            if (!IsPostBack)
            {
                

                var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
                using (SqlConnection con = new SqlConnection(connectionfromconfiguration.ConnectionString))
                {
                    SqlCommand da = new SqlCommand("Select * From Games ", con);
                    con.Open();
                    DropDownList2.DataTextField = "name";
                    DropDownList2.DataValueField = "game_id";
                    DropDownList2.DataSource = da.ExecuteReader();
                    DropDownList2.DataBind();
                    con.Close();
                    SqlCommand ca = new SqlCommand("Select * From Normal_Users ", con);
                    con.Open();
                    DropDownList1.DataTextField = "email";
                    DropDownList1.DataValueField = "email";
                    DropDownList1.DataSource = ca.ExecuteReader();
                    DropDownList1.DataBind();
                    con.Close();
                    ListItem z = new ListItem("Select Game", "-1");
                    DropDownList2.Items.Insert(0, z);
                    ListItem y = new ListItem("Select Member", "-1");
                    DropDownList1.Items.Insert(0, y);


                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection con = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand da = new SqlCommand("Recommendgame ", con);
                da.CommandType = CommandType.StoredProcedure;

                da.Parameters.Add(new SqlParameter("@me", Label1.Text));
                da.Parameters.Add(new SqlParameter("@friend", DropDownList1.SelectedItem.Value));
                da.Parameters.Add(new SqlParameter("@game", DropDownList2.SelectedItem.Value));

                con.Open();
                da.ExecuteNonQuery();
                con.Close();

                Label2.Text = "Recommendation Succeeded";
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}