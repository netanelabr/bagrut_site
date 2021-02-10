using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Project_Hope_You_Work.Pages
{
    public partial class UpdateForm : System.Web.UI.Page
    {
        protected string FirstName, LastName, FirstNError, LastNError;
        protected string Password, VerPass, PassError;
        protected string Email;
        protected string Gender, GenError, MaleCh, FemaleCh, otherCh;
        protected string FavCar, FavCarError, privateCh, offRodeCh, sportCh, superCarCh;
        protected string MultiLine, MultiLineError;
        protected string DateOfBirth, DOBError;
        protected string workt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null || Session["email"].ToString() == "")
            {
                Response.Redirect("ErrorPage.aspx");
            }
            if (Request.Form["firstName"] == null || Request.Form["firstName"] == "")//לבדוק אם זו הרצה ראשונית של האתר
            {
                firstRun();
            }
            else
            {
                Email = Session["email"].ToString();
                checkAll();
            }
        }
        void firstRun()//הרצה ראשונית לעמוד כדי שיכתוב את כל המידע שיש עליו בדטא בייס
        {
            DAL dal;
            DataTable dt;
            string db = MapPath("~/App_Data/MyDatabase.mdf");
            dal = new DAL(db);
            string sql = "select* from users where email='" + Session["email"].ToString() + "';";
            dt = dal.GetDataTable(sql);
            FirstName = dt.Rows[0]["firstName"].ToString();
            LastName = dt.Rows[0]["lastName"].ToString();
            Email = dt.Rows[0]["email"].ToString();
            Gender = dt.Rows[0]["gender"].ToString();
            FavCar = dt.Rows[0]["favoriteCar"].ToString();
            MultiLine = dt.Rows[0]["firstCar"].ToString();
            DateOfBirth = dt.Rows[0]["dateOfBirth"].ToString();
            genShow();
            favCarShow();
        }
        void genShow()//לדעת איזה מין הוא בחר
        {
            if (Gender == "male")
            {
                MaleCh = "checked";
            }
            else if (Gender == "female")
            {
                FemaleCh = "checked";
            }
            else
            {
                otherCh = "checked";
            }
        }
        void favCarShow()//לדעת איזה סיגנון מכוניות הוא בחר
        {
            string[] a = FavCar.Split(',');
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == "private")
                {
                    privateCh = "checked";
                }
                if (a[i] == "offRoad")
                {
                    offRodeCh = "checked";
                }
                if (a[i] == "sport")
                {
                    sportCh = "checked";
                }
                if (a[i] == "superCar")
                {
                    superCarCh = "checked";
                }
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
                FavCar = Request.Form["favCar"].ToString();
                string[] a = FavCar.Split(',');
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == "private")
                    {
                        privateCh = "checked";
                    }
                    if (a[i] == "offRoad")
                    {
                        offRodeCh = "checked";
                    }
                    if (a[i] == "sport")
                    {
                        sportCh = "checked";
                    }
                    if (a[i] == "superCar")
                    {
                        superCarCh = "checked";
                    }
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

            if (MultiLineError == null && FirstNError == null && LastNError == null && FavCarError == null && GenError == null && PassError == null)//לבדוק שאין שום תקלה בהרשמה
            {
                notFirstTime();
                UpdateSession();
            }
        }
        string PasswordCheck()//בדיקת סיסמה
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
        void UpdateSession()//עדכון הסשן
        {
            Session["firstName"] = FirstName;
            Session["email"] = Email;
        }
        void notFirstTime()//עדכון טבלת נתונים
        {
            DAL dal;
            DataTable dt;
            string db = MapPath("~/App_Data/MyDatabase.mdf");
            dal = new DAL(db);
            string sql = "update Users set firstName = N'"+FirstName+"', lastName = N'"+LastName+"', password = '"+Password+"', gender = '"+Gender+"', favoriteCar = '"+FavCar+"', firstCar = N'"+MultiLine+"', dateOfBirth = '"+DateOfBirth+"' where email = '"+Email+"'";
            dal.UpdateDB(sql);
            workt = "נתוניך עודכנו בהצלחה";
        }
    }
}