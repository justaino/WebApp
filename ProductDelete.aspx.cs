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
    public partial class ProductDelete : System.Web.UI.Page
    {
        private int productID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            btnBack1.Visible = false;
            
            productID = int.Parse(Request["pid"]);

            if (!IsPostBack)
            {

                SatiateLabels(productID);
            }
        }

        protected void btnYes_Command(object sender, CommandEventArgs e)
        {
            string title, description, price;
            int ProductID;

            title = lblProductName.Text;
            description = lblDescription.Text;
            price = lblPrice.Text;

            ProductID = int.Parse(Request["pid"]);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string updatequery = "DELETE FROM Item WHERE ItemID = @itemid";

            SqlCommand command = new SqlCommand(updatequery, con);
            command.Parameters.AddWithValue("@itemID", ProductID);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            lblSuccess.Visible = true;
            btnBack1.Visible = true;
            hide.Visible = false;

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
        //sample code from moodle used in this method
        private void SatiateLabels(int productID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT * FROM Item WHERE ItemID = @itemID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@itemid", productID);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblDescription.Text = reader["Description"].ToString();
                lblProductName.Text = reader["Title"].ToString();
                lblPrice.Text = reader["Price"].ToString();
                byte[] imgByte = (byte[])reader["Image"];
                image.Src = "data:Image/png;base64," + Convert.ToBase64String(imgByte);
            }
            con.Close();
        }

        protected void btnBack_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}