using System;
using System.Linq;

namespace Linq
{
    public partial class Cross_Join : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            from depts in sqlObj.tblDepartments
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