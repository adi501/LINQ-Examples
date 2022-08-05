using System;
using System.Data;
using System.Xml.Linq;

namespace Linq
{
    public partial class Create_a_XML_Using_Linq_which_contians_the_Employee_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable table1 = new DataTable("EmployeeDetails");
            table1.Columns.Add("ID", typeof(int));
            table1.Columns.Add("EmployeeName", typeof(string));
            table1.Columns.Add("Salary", typeof(decimal));
            table1.Columns.Add("Department", typeof(string));
            table1.Columns.Add("DOJ", typeof(DateTime));
            table1.Rows.Add(1, "Adi", "2000", "Travel", "2018-06-23 09:08:04.623");
            table1.Rows.Add(2, "Balu", "3000", "Travel", "2018-06-23 09:08:04.623");
            table1.Rows.Add(3, "Pavan", "1000", "Lunch", "2018-06-23 09:08:04.623");
            table1.Rows.Add(4, "Nani", "4000", "Travel", "2018-06-24 09:08:04.623");
            table1.Rows.Add(5, "Raju", "1000", "Lunch", "2018-06-25 09:08:04.623");
            
             System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Server.MapPath("~/XML/linqxml.xml"));
            string path=dir.ToString();
            new XElement("Employees",
                    from emp in table1.AsEnumerable()
                    orderby emp.Field<decimal>("Salary") descending
                    select new XElement("Employee",
                                 new XAttribute("EmployeeID", emp.Field<int>("ID")),
                                 new XAttribute("Salary", emp.Field<decimal>("Salary")),
                                 new XElement("Department", emp.Field<string>("Department")),
                                 new XElement("DOJ", emp.Field<DateTime>("DOJ").ToString("MM/dd/yyyy"))
                               )).Save(path);

        }
    }
}