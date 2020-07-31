using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_Website
{
    public partial class Products : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        string query;
        Trolley content = new Trolley();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                rptProductInfo.DataSource = GetProductInfo();
                rptProductInfo.DataBind();

                Label lbl = (Label)Master.FindControl("lblTrolley");
                lbl.Text = content.GetProductCount()+ " item(s) total €" + content.GetPriceTotal();


                
            }
        }

        protected void btnView_Command(object sender, CommandEventArgs e)
        {
            int productID = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("ProductInfo.aspx?pid=" + productID);
        }

        private object GetProductInfo()
        {
            DataTable dt = new DataTable();

            SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT * FROM Item";

            SqlCommand cmd = new SqlCommand(query, conn);


            conn.Open();

            dt.Load(cmd.ExecuteReader());

            conn.Close();

            return dt;
        }

        protected void btnAdd_Command(object sender, CommandEventArgs e)
        {
            int productID;

            Product product = new Product();

            productID = Convert.ToInt32(e.CommandArgument.ToString());

            query = "SELECT * FROM Item WHERE ItemID = @itemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", productID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                product.ItemID = Convert.ToInt32(reader["ItemID"]);
                product.Title = reader["Title"].ToString();
                product.Description = reader["Description"].ToString();
                product.price = Convert.ToDouble(reader["Price"]);
                byte[] images = (byte[])reader["Image"];
                product.Image = images;
            }

            content.AddProduct(product);

            Label lbl = (Label)Master.FindControl("lblTrolley");
            lbl.Text = content.GetProductCount() + " item(s) total: €" + content.GetPriceTotal();

        }
    }
}