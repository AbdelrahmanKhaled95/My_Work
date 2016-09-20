using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trial1
{

    public partial class Signup : System.Web.UI.Page
    {



        private static Boolean verifiedu;

        public static Boolean Verifiedu
        {
            get { return Signup.verifiedu; }
            set { Signup.verifiedu = value; }
        }
        private static Boolean develop;

        public static Boolean Develop
        {
            get { return Signup.develop; }
            set { Signup.develop = value; }
        }
        private static Boolean normalu;

        public static Boolean Normalu
        {
            get { return Signup.normalu; }
            set { Signup.normalu = value; }
        }
      
        protected void Page_Load(object sender, EventArgs e)
        {
           
           
        

        }
        protected void normal_Click(object sender, EventArgs e)
        {

            normalu = true;
            if (normalu == true)
            {
                verifiedu = false;
                develop = false;

            }



            Response.Redirect("NormalUser");

        }
        protected void verified_Click(object sender, EventArgs e)
        {
            verifiedu = true;
            if (verifiedu == true)
            {
                normalu = false;
                develop = false;

            }

           
            Response.Redirect("VerifiedReviewer.aspx");
        }
        protected void development_Click(object sender, EventArgs e)
        {
            develop = true;
            if (develop == true)
            {
                normalu = false;
                verifiedu = false;
            }
          
            Response.Redirect("DevelopmentTeam.aspx");
        }
       
    }
}