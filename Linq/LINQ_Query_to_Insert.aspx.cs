using System;

namespace Linq
{
    public partial class LINQ_Query_to_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            tblDepartment dept = new tblDepartment();
            dept.Name = "Deployment";
            sqlObj.tblDepartments.InsertOnSubmit(dept);
            sqlObj.SubmitChanges();

        }
    }
}