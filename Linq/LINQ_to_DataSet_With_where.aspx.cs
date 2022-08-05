using System;
using System.Data;

namespace Linq
{
    public partial class LINQ_to_DataSet_With_where : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable("EmployeeDetails");
            table1.Columns.Add("EmployeeName");
            table1.Columns.Add("ExpenseAmount");
            table1.Columns.Add("ExpenseDate");
            table1.Columns.Add("Expense");
            table1.Columns.Add("DepartmentName");
            table1.Rows.Add("Adi","2000","2018-06-23 09:08:04.623","Travel","IT" );
            table1.Rows.Add("Balu", "3000", "2018-06-23 09:08:04.623", "Travel", "IT");
            table1.Rows.Add("Pavan", "1000", "2018-06-23 09:08:04.623", "Lunch", "Hr");
            table1.Rows.Add("Nani", "4000", "2018-06-23 09:08:04.623", "Travel", "Hr");
            table1.Rows.Add("Raju", "1000", "2018-06-23 09:08:04.623", "Lunch", "IT");
            table1.Rows.Add("Krishna", "5000", "2018-06-23 09:08:04.623", "Lunch", "Hr");
            table1.Rows.Add("Adi", "2000", "2018-06-23 09:08:04.623", "Lunch", "IT");

            DataSet ds = new DataSet("office");
            ds.Tables.Add(table1);


            var res = from exp in ds.Tables[0].AsEnumerable()
                      where exp.Field<string>("EmployeeName") == "Adi"
                      select new
                      {
                          EmployeeName = exp.Field<string>("EmployeeName"),
                          ExpenseAmount = exp.Field<string>("ExpenseAmount"),
                          ExpenseDate = exp.Field<string>("ExpenseDate"),
                          Expense = exp.Field<string>("Expense"),
                          DepartmentName = exp.Field<string>("DepartmentName"),
                      };

            gv1.DataSource = res;
            gv1.DataBind();

        }
    }
}