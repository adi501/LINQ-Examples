using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Creating_a_New_Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                db.ExecuteCommand("Create table employees(ID int, Name varchar(50), Department varchar(50))");
                db.SubmitChanges();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                db.ExecuteCommand("Create table employees1(ID int identity(100,1), Name varchar(50), Department varchar(50))");
                db.SubmitChanges();
            }
        }
    }
}