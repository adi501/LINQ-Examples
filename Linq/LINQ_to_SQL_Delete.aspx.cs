using System;
using System.Linq;

namespace Linq
{
    public partial class LINQ_to_SQL_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            tblDepartment dept = sqlObj.tblDepartments.Single(x => x.Id == 5);
            sqlObj.tblDepartments.DeleteOnSubmit(dept);
            sqlObj.SubmitChanges();

        }
    }
}