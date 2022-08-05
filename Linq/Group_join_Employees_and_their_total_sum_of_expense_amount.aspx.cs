using System;
using System.Linq;

namespace Linq
{
    public partial class Group_join_Employees_and_their_total_sum_of_expense_amount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            join empexp in sqlObj.tblEmployeeExpenses on emps.Id equals empexp.Emp_Id into g
                            select new
                            {
                                emps.Id,
                                emps.Name,
                                emps.Salary,
                                ExpenseAmount = g.Sum(x => (decimal?)x.Amount)
                            };
            gv1.DataSource = employees;
            gv1.DataBind();

        }
    }
}