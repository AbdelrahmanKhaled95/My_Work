using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace trial1
{
    public partial class CreateCom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "";
            if (Login.Oldmember == true)
                name = Login.Username;
            else if (Signup.Normalu == true)
                name = NormalUser.Email;
            else if (Signup.Verifiedu == true)
                name = VerifiedReviewer.Email;
            else name = DevelopmentTeam.Email;

            lblmail.Text = name;
           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //string mail="";
            //if(prevPage!=null)


            string connStr = ConfigurationManager.ConnectionStrings["Team"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("createcomm", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string theme = txtTheme.Text;
            string mail = lblmail.Text;
           string name = txtName.Text;
           string desc = txtDes.Text;

            cmd.Parameters.Add(new SqlParameter("@theme",theme));
            cmd.Parameters.Add(new SqlParameter("@email", mail));
            SqlParameter accept = cmd.Parameters.Add("@accept", SqlDbType.Int);
            accept.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@name",name));
            cmd.Parameters.Add(new SqlParameter("@des", desc));
            

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            if (accept.Value.ToString().Equals("1"))
            {

                Label4.Text = "You created a community succesfully";

            }
            else if (accept.Value.ToString().Equals("0"))
            {
                Label4.Text = "Please choose another theme as this theme already exists";
                txtTheme.Text = "";
            }
            else
            {
                Label4.Text = "You are not allowed to create community as you are not a normal user";
            }
            //else 
            //{
             //   Label4.Text = "this request had send before";
            //}

            
        }
    }
}