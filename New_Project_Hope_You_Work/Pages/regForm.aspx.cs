using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class regForm : System.Web.UI.Page
    {
        protected string FirstName, LastName, FirstNError, LastNError;
        protected string Password, VerPass, PassError;
        protected string Email, EmailError;
        protected string Gender, GenError, MaleCh, FemaleCh, otherCh;
        protected string FavCar, FavCarError, privateCh, offRodeCh, sportCh, superCarCh;
        protected string MultiLine, MultiLineError;
        protected string DateOfBirth, DOBError;
        protected string admin;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["firstName"] != null)
            {
                checkAll();
            }
        }
        void checkAll()
        {
            if (Request.Form["firstName"] != null && Request.Form["firstName"].ToString() != "")//בדיקת שם פרטי
            {
                FirstName = Request.Form["firstName"].ToString();
            }
            else
            {
                FirstNError = "חובה למלא שם פרטי";
            }

            if (Request.Form["lastName"] != null && Request.Form["lastName"].ToString() != "")//בדיקת שם משפחה
            {
                LastName = Request.Form["lastName"].ToString();
            }
            else
            {
                LastNError = "חובה למלא שם משפחה";
            }

            PassError = PasswordCheck();//בדיקת סיסמה

            if (EmailCheck() == true)//בדיקת אימייל
            {
                DAL dal;
                DataTable dt;
                string db = MapPath("~/App_Data/MyDatabase.mdf");
                dal = new DAL(db);
                string sql = "select* from users";
                dt = dal.GetDataTable(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Request.Form["email"].ToString() == dt.Rows[i]["email"].ToString())
                    {
                        EmailError = "האימייל כבר תפוס אנא השתמש באימייל אחר";
                    }
                    else
                    {
                        Email = Request.Form["email"].ToString();
                    }
                }
            }
            else
            {
                EmailError = "אנא רשום אימייל תקין";
            }

            if (Request.Form["gender"] != null && Request.Form["gender"].ToString() != "")//בדיקה אם נבחר מין
            {
                Gender = Request.Form["gender"].ToString();
                if (Request.Form["gender"].ToString() == "male")
                {
                    MaleCh = "checked";
                }
                else if (Request.Form["gender"].ToString() == "female")
                {
                    FemaleCh = "checked";
                }
                else
                {
                    otherCh = "checked";
                }
            }
            else
            {
                GenError = "חובה לבחור מין";
            }

            if (Request.Form["favCar"] != null)//בדיקה אם נבחר מכונית אהובה
            {
                string[] h = Request.Form["favCar"].ToString().Split(',');
                FavCar = "";
                for (int i = 0; i < h.Length; i++)
                {
                    FavCar += h[i] ;
                }
                if (Request.Form["favCar"].ToString() == "private")
                {
                    privateCh = "checked";
                }
                else if (Request.Form["favCar"].ToString() == "offRoad")
                {
                    offRodeCh = "checked";
                }
                else if (Request.Form["favCar"].ToString() == "sport")
                {
                    sportCh = "checked";
                }
                else if (Request.Form["favCar"].ToString() == "superCar")
                {
                    superCarCh = "checked";
                }
            }
            else
            {
                FavCarError = "חובה לבחור סוג מכונית אהובה";
            }            

            if (Request.Form["multiLine"] != null && Request.Form["multiLine"].ToString() != "")//בדיקה אם כתבו
            {
                MultiLine = Request.Form["multiLine"].ToString();
            }
            else
            {
                MultiLineError = "חובה לכתוב על המכונית הראשונה,\n אם לא היה תכתוב לא היה";
            }

            if (Request.Form["dateOfBirth"] != "a")//בדיקה אם הוכנס שנת לידה
            {
                DateOfBirth = Request.Form["dateOfBirth"].ToString();
            }
            else
            {
                DOBError = "חובה לבחור שנת לידה";
            }

            if (EmailError == null && MultiLineError == null && FirstNError == null && LastNError == null && FavCarError == null && GenError == null && PassError == null )//לבדוק שאין שום תקלה בהרשמה
            {
                DAL dal;
                string db = MapPath("~/App_Data/MyDatabase.mdf");
                dal = new DAL(db);
                string sql = "insert into users (email, firstName, lastName, password, gender, favoriteCar, firstCar, dateOfBirth, admin)" +
                    "values ('"+Email+"', N'"+FirstName + "', N'" + LastName + "', '" + Password + "', '" + Gender + "', '" + FavCar + "', N'" + MultiLine + "', '" + DateOfBirth + "', 'no') ";
                dal.UpdateDB(sql);


                UpdateSession();          
            }
        }


        bool EmailCheck()
        {
            Email = Request.Form["email"];
            if (Email == null)
            {
                return false;
            }
            int begin = Email.IndexOf('@');
            int end = Email.LastIndexOf('@');
            if (begin > 0 && begin == end)
            {
                int period = Email.LastIndexOf('.');
                if (period > begin)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        string PasswordCheck()
        {
            if (Request.Form["password"] == null || Request.Form["verPassword"] == null)
                return "הכנס את הסיסמה מחדש";
            Password = Request.Form["password"].ToString();
            VerPass = Request.Form["verPassword"].ToString();
            if (Password != VerPass)
            {
                return "על הסיסמאות להתאים";
            }

            if (Password.Length <= 3)
            {
                return "על הסיסמה להיות ארוכה מ3 אותיות";
            }
            bool letter = false;
            bool num = false;
            for (int i = 0; i < Password.Length; i++)
            {
                if (Password[i] >= 'a' && Password[i] <= 'z' || Password[i] >= 'A' && Password[i] <= 'Z')
                {
                    letter = true;
                }
                if (Password[i] >= '0' && Password[i] <= '9')
                {
                    num = true;
                }

            }
            if (letter != true || num != true)
            {
                return "הסיסמה חייבת להכיל אותיות באנגלית ומספרים";
            }
            else
                return null;
            
           
        }
        void UpdateSession()
        {
            Session["firstName"] = FirstName;
            Session["email"] = Email;
        }
    }
}