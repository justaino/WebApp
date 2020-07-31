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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string passwordConfirm = txtPasswordConfirm.Text;

                if (password == passwordConfirm)
                {
                    if (NotDuplicateUsername(username))
                    {
                        InsertUser(firstName, lastName, username, password);
                        Response.Redirect("Login.aspx");
                    }
                    else
                        lblAlreadyExists.Text = "This Username already exists";
                }
                else
                    lblAlreadyExists.Text = "Your passwords do not match. Please try again";
            }
        }
        //basics of code from moodle
        private void InsertUser(string firstName, string lastName, string username, string password)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "INSERT INTO Users(Forename, Surname, Username, Password) VALUES " + "(@Forename, @Surname, @Username, @Password);";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@Forename", firstName);
            command.Parameters.AddWithValue("@Surname", lastName);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();
        }

        private bool NotDuplicateUsername(string username)
        {
            int rowCounter = 1;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Username", username);

            conn.Open();

            rowCounter = (int)command.ExecuteScalar();

            conn.Close();

            return (rowCounter == 0);
        }
    }
}