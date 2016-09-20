using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trial1
{
    public partial class Login : System.Web.UI.Page
    {
        private static string username;

        public static string Username
        {
            get { return Login.username; }
            set { Login.username = value; }
        }

        private static Boolean oldmember;

        public static Boolean Oldmember
        {
            get { return Login.oldmember; }
            set { Login.oldmember = value; }
        }



        private static Boolean iamnormaluser;

        public static Boolean Iamnormaluser
        {
            get { return Login.iamnormaluser; }
            set { Login.iamnormaluser = value; }
        }
        private static Boolean iamverified;

        public static Boolean Iamverified
        {
            get { return Login.iamverified; }
            set { Login.iamverified = value; }
        }
        private static Boolean iamdevelop;

        public static Boolean Iamdevelop
        {
            get { return Login.iamdevelop; }
            set { Login.iamdevelop = value; }
        }
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void done_Click(object sender, EventArgs e)
        {
           
            string connStr = ConfigurationManager.ConnectionStrings["Team"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
            SqlCommand cmd = new SqlCommand("login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            username = emailbox.Text;
            string password = passBox.Text;
            cmd.Parameters.Add(new SqlParameter("@email", username));

            SqlParameter name = cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50);
            name.Value = password;

            // output parm
            SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
            count.Direction = ParameterDirection.Output; 
            conn.Open();
            cmd.ExecuteNonQuery();
           
            int x = Int32.Parse(cmd.Parameters["@count"].Value.ToString());
            if (x == 1)
            {
                oldmember = true;

            }
            else
                Response.Redirect("Error");
            //////////////////////////////////////////////////////////////////////
            SqlCommand cmd2 = new SqlCommand("iamnormal", conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add(new SqlParameter("@email", username));
            // output parm
            SqlParameter count2 = cmd2.Parameters.Add("@count", SqlDbType.Int);
            count2.Direction = ParameterDirection.Output;
           
            cmd2.ExecuteNonQuery();
            int x2 = Int32.Parse(cmd2.Parameters["@count"].Value.ToString());
            if (x2 == 1)
            {
                iamnormaluser = true;
                Response.Redirect("GamersNetwork.aspx");
            }
            ///////////////////////////////////////////////////////////
            SqlCommand cmd3 = new SqlCommand("iamverified", conn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add(new SqlParameter("@email", username));
            // output parm
            SqlParameter count3 = cmd3.Parameters.Add("@count", SqlDbType.Int);
            count3.Direction = ParameterDirection.Output;
            
            cmd3.ExecuteNonQuery();
            int x3 = Int32.Parse(cmd3.Parameters["@count"].Value.ToString());
            if (x3 == 1)
            {
                Iamverified = true;
                Response.Redirect("GamersNetworkverified.aspx");
            }
            //////////////////////////////////////////////////////////
            SqlCommand cmd4 = new SqlCommand("iamdevelop", conn);
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.Add(new SqlParameter("@email", username));
            // output parm
            SqlParameter count4 = cmd4.Parameters.Add("@count", SqlDbType.Int);
            count4.Direction = ParameterDirection.Output;

            cmd4.ExecuteNonQuery();
            int x4 = Int32.Parse(cmd4.Parameters["@count"].Value.ToString());
            if (x4 == 1)
            {
                Iamdevelop = true;
                Response.Redirect("GamersNetworkdevelop.aspx");
            }

                
        
        }


        
    }
}