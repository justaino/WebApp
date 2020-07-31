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
    public partial class Create : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            btnCreatePlus.Visible = false;
            btnCreatePlus.Visible = false;
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {

                string title = txtTitle.Text;

                string description = txtDescription.Text;

                string price = txtPrice.Text;

                //code from moodle
                byte[] imagebytes = new byte[FileUpload.PostedFile.InputStream.Length + 1];
                FileUpload.PostedFile.InputStream.Read(imagebytes, 0, imagebytes.Length);

                query = "INSERT INTO Item(Title, Description, Price, Image) VALUES " + "(@title, @description, @price, @image)";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@image", imagebytes);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                title = string.Empty;
                description = string.Empty;
                price = string.Empty;
                lblUploaded.Text = "Upload successful!";

                hide.Visible = false;
                lblSuccess.Visible = true;
                btnCreatePlus.Visible = true;
            }
            else
            {
                lblUploaded.Text = "Please upload an image";
            }
        }

        protected void btnCreatePlus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }
    }
}