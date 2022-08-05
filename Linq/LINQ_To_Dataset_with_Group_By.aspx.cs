using System;
using System.Data;
using System.Linq;

namespace Linq
{
    public partial class LINQ_To_Dataset_with_Group_By : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable table1 = new DataTable("EmployeeDetails");
            table1.Columns.Add("EmployeeName",typeof(string));
            table1.Columns.Add("ExpenseAmount",typeof(decimal));
            table1.Columns.Add("ExpenseDate",typeof(DateTime));
            table1.Columns.Add("Expense",typeof(string));
            table1.Columns.Add("DepartmentName",typeof(string));
            table1.Rows.Add("Adi", "2000", "2018-06-23 09:08:04.623", "Travel", "IT");
            table1.Rows.Add("Balu", "3000", "2018-06-23 09:08:04.623", "Travel", "IT");
            table1.Rows.Add("Pavan", "1000", "2018-06-23 09:08:04.623", "Lunch", "Hr");
            table1.Rows.Add("Nani", "4000", "2018-06-24 09:08:04.623", "Travel", "Hr");
            table1.Rows.Add("Raju", "1000", "2018-06-25 09:08:04.623", "Lunch", "IT");
            table1.Rows.Add("Krishna", "5000", "2018-06-23 09:08:04.623", "Lunch", "Hr");
            table1.Rows.Add("Adi", "2000", "2018-06-23 09:08:04.623", "Lunch", "IT");

            DataSet ds = new DataSet("office");
            ds.Tables.Add(table1);

            var res = from exp in ds.Tables[0].AsEnumerable()
                      group exp by exp.Field<DateTime>("ExpenseDate") into temp
                      select new
                      {
                          Date = temp.Key.ToString("MM/dd/yyyy"),
                          Amount = temp.Sum(s => s.Field<decimal>("ExpenseAmount"))
                      };

            gv1.DataSource = res;
            gv1.DataBind();

        }
    }
}