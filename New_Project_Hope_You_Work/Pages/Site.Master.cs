using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected string regPage, loginPage, logoutPage, userUpdatePage, adminPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstName"] == null || Session["firstName"] == "אורח")
            {
                Session["firstName"] = "אורח";
                Session["email"] = "";
                Session["admin"] = "no";
                regPage = "<a href=regForm.aspx>טופס הרשמה</a>";
                userUpdatePage = "";
                adminPage = "";
                loginPage = "<a href=Login.aspx>התחברות</a>";
                logoutPage = "";
            }
            else
            {
                if (Session["firstName"].ToString() != "אורח")
                {
                    regPage = "";
                    userUpdatePage = "<a href=UpdateForm.aspx>עדכון פרטים</a>";
                    adminPage = "";
                    loginPage = "";
                    logoutPage = "<a href=Logout.aspx>התנתקות</a>";
                }
                if (Session["admin"].ToString() == "yes")
                {
                    adminPage = "<a href=Admin.aspx>דף מנהל</a>";
                }
            }
        }
    }
}