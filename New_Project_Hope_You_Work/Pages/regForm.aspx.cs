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
        protected string FirstName, LastName;        
        protected string Password, VerPass, PassError;
        protected string Email, EmailError;
        protected string Gender, GenError;
        protected string FavCar, FavCarError;
        protected string MultiLine, MultiLineError;
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
                PassError = PassCheck();
            }
            else
            {
                PassError = PassCheck();
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
            if (Request.Form["password"] == null || Request.Form["verPassword"] == null)
                return "Please Reenter The Password";
            Password = Request.Form["password"].ToString();
            VerPass = Request.Form["verPassword"].ToString();
            if (Password != VerPass)
            {
                return "Passwords Must Match";
            }

            if (Password.Length <= 3)
            {
                return "Password Must Be Longer Then Three Characters";
            }
                int counter = 0;
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Password[i] != VerPass[i])
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
        //string EmailCheck()
        //{

        //}
    }
}