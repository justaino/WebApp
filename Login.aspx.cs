using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace E_Commerce_Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            logged.Visible = false;
            signIn.Visible = false;
            bool userSignedIn = false;
            string username = string.Empty;
            string password = string.Empty;

            if (IsPostBack)
            {
                username = txtUsername.Text;
                password = txtPassword.Text;

                userSignedIn = UserExists(username, password);

                if (userSignedIn)
                {
                    Session.Add("username", username);



                    Response.Redirect("CheckOut.aspx");
                }
                else
                {
                    lblLoggedIn.Text = "Username or password do not match. Please try again";
                }

            }
            else
            {
                if (Session["username"] != null)
                {
                    /*signIn.Visible = true;
                    hide.Visible = false;*/

                    Response.Redirect("LogOut.aspx");
                }
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private bool UserExists(string username, string password)
        {
            int rowCount = 0;

            SqlConnection conn = new
              SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username " +
               "AND Password = @password";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            conn.Open();

            rowCount = (int)command.ExecuteScalar();

            conn.Close();

            return (rowCount == 1);
        }




    
       protected void btnLogOut_Click1(object sender, EventArgs e)
        {
            /*HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "2;url=Default.aspx";
            this.Page.Controls.Add(meta);
            Session["username"] = null;

            logged.Visible = true;*/
        }
    }
}