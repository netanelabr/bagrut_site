using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected string Email;
        protected string Password;
        protected string Error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["logEmail"] != null)
            {
                Email = Request.Form["logEmail"].ToString();
                Password = Request.Form["logPassword"].ToString();
                exist();
                
            }            
        }
        void exist()
        {
            DAL dal;
            DataTable dt;
            string db = MapPath("~/App_Data/MyDatabase.mdf");
            dal = new DAL(db);
            string sql = "select * from Users where email = '" + Email + "'and password = '" + Password + "'";            
            dt = dal.GetDataTable(sql);
            if (dt.Rows.Count == 1)
            {
                Session["firstName"] = dt.Rows[0]["firstName"].ToString();
                Session["email"] = dt.Rows[0]["email"].ToString();
                Session["admin"] = dt.Rows[0]["admin"].ToString();
                Response.Redirect("Home.aspx");
            }
            else
            {
                Error = "אימייל ו/או סיסמה אינם נכונים";
            }
        }
    }
}