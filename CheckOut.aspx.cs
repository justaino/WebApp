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
    public partial class CheckOut : System.Web.UI.Page
    {
        Trolley content = new Trolley();
        string query;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        Product product = new Product();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (content.GetTrolleyContent().Count == 0)
            {
                Response.Redirect("Products.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    DisplayTrolleyContent();
                }
            }
        }

        protected void lbtnDelete_Command(object sender, CommandEventArgs e)
        {
            int productID;

            productID = Convert.ToInt32(e.CommandArgument.ToString());

            query = "SELECT * FROM Item WHERE ItemID = @ItemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", productID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                product.ItemID = Convert.ToInt32(reader["ItemID"]);
                product.Title = reader["Title"].ToString();
                product.Description = reader["Description"].ToString();
                product.price = double.Parse(reader["Price"].ToString());
                byte[] images = (byte[])reader["Image"];
                product.Image = images;
            }
            content.DeleteProduct(product);
            DisplayTrolleyContent();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("ThankYou.aspx");

            }

            else
            {
                Response.Redirect("Login.aspx");
            }



        }

        private void DisplayTrolleyContent()
        {
            rptCheckOut.DataSource = content.GetTrolleyContent();
            rptCheckOut.DataBind();
            lblTotal.Text = "€" + content.GetPriceTotal();
        }


    }
}