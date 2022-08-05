using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Insert_data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                tbl_emp objtbl_emp = new tbl_emp();
                objtbl_emp.Name = txt_name.Text.Trim();
                db.tbl_emps.InsertOnSubmit(objtbl_emp);
                db.SubmitChanges();
            }
        }
    }
}