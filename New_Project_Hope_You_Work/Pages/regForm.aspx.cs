using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class regForm : System.Web.UI.Page
    {
        protected string FirstName;
        protected string LastName;
        protected string Password;
        protected string Email;
        protected string Gender;
        protected string FavCar;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["firstName"] != null)
            {
                FirstName = Request.Form["firstName"].ToString();
            }
            if (Request.Form["lastName"] != null)
            {
                LastName = Request.Form["lastName"].ToString();
            }
            if (Request.Form["password"] != null)
            {
                Password = Request.Form["password"].ToString();
            }
            if (Request.Form["email"] != null)
            {
                Email = Request.Form["email"].ToString();
            }
            if (Request.Form["gender"] != null)
            {
                Gender = Request.Form["gender"].ToString();
            }
            if (Request.Form["favCar"] != null)
            {
                FavCar = Request.Form["favCar"].ToString();
            }
        }
    }
}