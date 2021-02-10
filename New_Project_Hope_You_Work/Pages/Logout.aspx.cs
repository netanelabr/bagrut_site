using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["firstName"] = "אורח";
            Session["email"] = "";
            Session["admin"] = "no";
            Response.Redirect("Home.aspx");
        }
    }
}