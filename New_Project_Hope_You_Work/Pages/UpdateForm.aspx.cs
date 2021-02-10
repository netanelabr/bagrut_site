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
        protected void Page_Load(object sender, EventArgs e)
        {            
            DAL dal;
            DataTable dt;
            string db = MapPath("~/App_Data/MyDatabase.mdf");
            dal = new DAL(db);
            string sql = "select* from users where email='"+ Session["email"].ToString() + "';";
            dt = dal.GetDataTable(sql);
            FirstName = dt.Rows[0]["firstName"].ToString();
            LastName = dt.Rows[0]["lastName"].ToString();
            Email = dt.Rows[0]["email"].ToString();
            Gender = dt.Rows[0]["gender"].ToString();
            FavCar = dt.Rows[0]["favoriteCar"].ToString();
            MultiLine = dt.Rows[0]["firstCar"].ToString();
            DateOfBirth = dt.Rows[0]["dateOfBirth"].ToString();
        }
        
    }
}