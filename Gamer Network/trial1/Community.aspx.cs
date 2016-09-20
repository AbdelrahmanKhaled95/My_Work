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
    public partial class Community : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name="";
            if (Login.Oldmember = true)
                name = Login.Username;
            else if (Signup.Normalu == true)
                name = NormalUser.Email;
            else if (Signup.Verifiedu == true)
                name = VerifiedReviewer.Email;
            else name = DevelopmentTeam.Email;

            lblmail.Text = name;
            

            
        }

  

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}