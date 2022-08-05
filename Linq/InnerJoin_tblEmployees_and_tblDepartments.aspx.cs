using System;
using System.Linq;

namespace Linq
{
    public partial class InnerJoin_tblEmployees_and_tblDepartments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            join depts in sqlObj.tblDepartments on emps.Dep_Id equals depts.Id
                            select new
                            {
                                emps.Id,
                                emps.Name,
                                emps.Salary,
                                Dep_Name = depts.Name
                            };
            gv1.DataSource = employees;
            gv1.DataBind();

        }
    }
}