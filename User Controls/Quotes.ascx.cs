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
    public partial class Quotes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            rptQuotes.DataSource = GetQuote();
            rptQuotes.DataBind();


        }

        private object GetQuote()
        {
            DataTable dt = new DataTable();

            SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

            string query = "SELECT TOP 1 * FROM Quotes ORDER BY newid()";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            dt.Load(cmd.ExecuteReader());

            conn.Close();

            return dt;
        }
    }
}