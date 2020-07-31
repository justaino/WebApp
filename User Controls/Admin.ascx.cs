using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_Website
{
    public partial class Admin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
              
            }
            
            

        }

        private bool AdminExists(string username, string password)
        {
            int rowCounter = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT COUNT(*) FROM Admin " + "WHERE UserName = @username AND Password = @password";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            conn.Open();

            rowCounter = (int)command.ExecuteScalar();

            rowCounter = (int)command.ExecuteScalar();

            conn.Close();

            return (rowCounter == 1);

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            bool signedIn = false;
            string username = string.Empty, password = string.Empty;

            username = txtUsername.Text;
            password = txtPassword.Text;

            signedIn = AdminExists(username, password);

            if (signedIn)
            {
               

                lblLoggedIn.Text = "You have signed in!";

                HttpContext.Current.Session["Username"] = username;

                Response.Redirect("AdminHomePage.aspx");


                

            }
            else
            {
                lblLoggedIn.Text = "This Admin does not exist";
            }
            txtUsername.Text = string.Empty;
        }
    }
}