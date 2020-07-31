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
    public partial class ProductEdit : System.Web.UI.Page
    {
        private int productID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            btnOK.Visible = false;
            productID = int.Parse(Request["pid"]);

            if (!IsPostBack)
            {
                
                AddProductDetails(productID);
            }
        }

        private void AddProductDetails(int productID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT * FROM Item WHERE ItemID = @itemID";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@itemID", productID);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtTitle.Text = reader["Title"].ToString();
                txtDescription.Text = reader["Description"].ToString();
                txtPrice.Text = reader["Price"].ToString();
                byte[] imgByte = (byte[])reader["Image"];
                image.Src = "data:Image/png;base64," + Convert.ToBase64String(imgByte);
            }

            con.Close();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string title, description, price;
            int ProductID = int.Parse(Request["pid"]);

            title = txtTitle.Text;
            description = txtDescription.Text;
            price = txtPrice.Text;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);


            //stack overflow consulted to get htmlcontrols as well as code from moodle for editing data 
            if (FileUpload.HasFile)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;url=AdminHomePage.aspx";
                this.Page.Controls.Add(meta);
                byte[] imagebytes =
                       new byte[FileUpload.PostedFile.InputStream.Length + 1];
                FileUpload.PostedFile.InputStream.Read(imagebytes, 0, imagebytes.Length);

                string queryUpdate2 = "UPDATE Item SET Title = @title, " +
               "Description = @description, " +
               "Price = @price, " +
               "Image = @img WHERE ItemID = @itemid";

                SqlCommand cmd = new SqlCommand(queryUpdate2, connection);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@itemid", ProductID);
                cmd.Parameters.AddWithValue("@img", imagebytes);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();

                lblSuccess.Visible = true;
                hide.Visible = false;

            }
            else
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;url=AdminHomePage.aspx";
                this.Page.Controls.Add(meta);
                string queryUpdate = "UPDATE Item SET Title = @title, " +
               "Description = @description, " +
               "Price = @price WHERE ItemID = @itemid";

                SqlCommand command = new SqlCommand(queryUpdate, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@itemid", ProductID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                lblSuccess.Visible = true;

                hide.Visible = false;
            }
        }

        protected void btnBack1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}