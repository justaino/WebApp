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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //rptProductInfo.DataSource = GetProductInfo();
                //rptProductInfo.DataBind();
            }
        }

        protected void btnView_Command(object sender, CommandEventArgs e)
        {
            int productID = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("ProductInfo.aspx?pid=" + productID);

            
        }

        //tried displaying 2 random products on here
        //Gave up to concentrate on other
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
    }
}