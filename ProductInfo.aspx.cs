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
    public partial class ProductInfo : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        string query;
        Trolley content = new Trolley();
        private int productID;
        protected void Page_Load(object sender, EventArgs e)
        {
            productID = int.Parse(Request["pid"]);

            if(!IsPostBack)
            {
                Label lbl = (Label)Master.FindControl("lblTrolley");
                lbl.Text = content.GetProductCount() + " items in cart for a total of " + "€" + content.GetPriceTotal();

                SatiateLabels(productID);
            }
        }

        private void SatiateLabels(int productID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT Title, Description, Price, Image FROM Item WHERE ItemID = @itemID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@itemid", productID);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblDescription.Text = reader["Description"].ToString();
                lblProductName.Text = reader["Title"].ToString();
                lblPrice.Text = reader["Price"].ToString(); 
                byte[] images = (byte[])reader["Image"];
                img.Src = "data:Image/png;base64," + Convert.ToBase64String(images);

            }
            con.Close();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Redirect("Products.aspx");
            }
        }

        protected void btnAdd_Command(object sender, CommandEventArgs e)
        {
           // int productID;

            Product product = new Product();

            query = "SELECT Title, Description, Price, Image FROM Item WHERE ItemID = @itemID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", productID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                product.Title = reader["Title"].ToString();
                product.Description = reader["Description"].ToString();
                product.price = Convert.ToDouble(reader["Price"]);
                byte[] images = (byte[])reader["Image"];
                product.Image = images;
            }


            content.AddProduct(product);

            Label lbl = (Label)Master.FindControl("lblTrolley");
            lbl.Text = content.GetProductCount() + " items in cart for a total of " + "€" + content.GetPriceTotal();

        }
    }
}