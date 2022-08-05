using System;
using System.Linq;

namespace Linq
{
    public partial class LINQ_query_will_get_the_employee_details_from_database_table_tblEmployees_who_are_having_Salary_more_than_200000 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            where emps.Salary > 200000
                            orderby emps.Name
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