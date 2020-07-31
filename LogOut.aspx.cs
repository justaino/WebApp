using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


namespace E_Commerce_Website
{   //Was able to achieve log out by redirecting to another page.... might have had something to do with the post back
    //and one boolean statement overiding the other
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLogged.Visible = false;
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "2;url=Default.aspx";
            this.Page.Controls.Add(meta);
            Session["username"] = null;

            lblLogged.Visible = true;
            hide.Visible = false;
        }
    }
}