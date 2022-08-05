using System;
using System.Linq;

namespace Linq
{
    public partial class Left_outer_join_on_tblEmployees_and_tblDepartments_table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            join de in sqlObj.tblDepartments on emps.Dep_Id equals de.Id into dep
                            from dept in dep.DefaultIfEmpty()
                            select new
                            {
                                emps.Id,
                                emps.Name,
                                emps.Salary,
                                Dep_Name = dept.Name
                            };
            gv1.DataSource = employees;
            gv1.DataBind();


        }
    }
}