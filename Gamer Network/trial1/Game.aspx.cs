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
namespace trail1
{
    public partial class Game : System.Web.UI.Page
    {
        String gamename = "";
        string name="";
           
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                

                 var connectionfromconfiguration = WebConfigurationManager.ConnectionStrings["Team"];
            using (SqlConnection con = new SqlConnection(connectionfromconfiguration.ConnectionString))
            {
                SqlCommand da = new SqlCommand("Select * From Games ", con);
                con.Open();
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "name";
                DropDownList1.DataSource = da.ExecuteReader();
                DropDownList1.DataBind();
                con.Close();

                ListItem y = new ListItem("Select Game", "-1");
                DropDownList1.Items.Insert(0, y);

                //DataSet ds1 = new DataSet();
                //da.Fill(ds1);
                //GridView1.DataSource = ds1;
                //GridView1.DataBind();
            }
            }
            
            
           // if (Request.Cookies["Start"] != null)
            //{
              //  Label1.Text = Request.Cookies["Start"].Value;
            //}
 
            




        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Value.ToString();
                   
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("");
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}