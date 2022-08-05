using System;
using System.Linq;

namespace Linq
{
    public partial class Inner_join_multiple_tables_by_using : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblEmployees
                            join depts in sqlObj.tblDepartments on emps.Dep_Id equals depts.Id
                            join empexp in sqlObj.tblEmployeeExpenses on emps.Id equals empexp.Emp_Id
                            join exp in sqlObj.tblExpenses on empexp.Expenses_Id equals exp.Id
                            select new
                            {
                                emps.Id,
                                emps.Name,
                                emps.Salary,
                                Dep_Name = depts.Name,
                                exp.Expenses,
                                ExpenseAmount = empexp.Amount,
                                ExpenseDate = empexp.ExpenseDate
                            };
            gv1.DataSource = employees;
            gv1.DataBind();

        }
    }
}