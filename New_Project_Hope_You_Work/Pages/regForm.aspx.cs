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
        protected string verPass;
        protected string Email;
        protected string Gender;
        protected string FavCar;
        protected string MultiLine;
        protected string passErr;
        protected string emailErr;
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
            if (PassCheck() == "")
            {
                Password = Request.Form["password"].ToString();
                passErr = PassCheck();
            }
            else
            {
                passErr = PassCheck();
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
            if (Request.Form["multiLine"] != null)
            {
                MultiLine = Request.Form["multiLine"].ToString();
            }
           
        }
        string PassCheck()
        {
            if (Password == null)
            {
                return passErr;
            }
            if (Password.Length == verPass.Length)
            {
                if (Password.Length <= 3)
                {
                    return "Password Must Be Longer Than 3 Characters";
                }
                int counter = 0;
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Password[i] != verPass[i])
                    {
                        return "Passwords Must Match";
                    }
                    if(Password[i]>='a' && Password[i] <= 'z')
                    { 
                        counter++;
                    }
                    if(Password[i] >= 0 && Password[i] <= 9)
                    {
                        counter++;
                    }
                    
                }
                if (counter >= 2)
                {
                    return "Passeord Must Have Letters And Numbers";
                }
                else
                    return "";
            }
            else if (Password.Length != verPass.Length)
            {
                return "Passwords Must Match";
            }
            else
                return "";
        }
        //string EmailCheck()
        //{

        //}
    }
}