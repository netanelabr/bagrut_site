using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() != "yes")
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }
    }
}