using System;
using System.Linq;

namespace Linq
{
    public partial class LINQ_query_will_get_the_employee_details_from_database_table_tblEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            select new
                            {
                                emps.Id,
                                emps.Name,
                                emps.Salary
                            };
            gv1.DataSource = employees;
            gv1.DataBind();

        }
    }
}