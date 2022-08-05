using System;
using System.Linq;

namespace Linq
{
    public partial class LINQ_to_XML_Where_condition_to_filter_records : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Xml.Linq.XDocument xdoc = System.Xml.Linq.XDocument.Parse(@"<Employees>
    <Employee>
        <Name>Thomas</Name>
        <Designation>Executive</Designation>
        <Department>Accounts</Department>
        <Salary>5000</Salary>
    </Employee>
    <Employee>
        <Name>Wills</Name>
        <Designation>Manager</Designation>
        <Department>Accounts</Department>
        <Salary>24000</Salary>
    </Employee>
    <Employee>
        <Name>Brod</Name>
        <Designation>Manager</Designation>
        <Department>Finance</Department>
        <Salary>28000</Salary>
    </Employee>
    <Employee>
        <Name>Smith</Name>
        <Designation>Analyst</Designation>
        <Department>Finance</Department>
        <Salary>21000</Salary>
    </Employee>
</Employees>
");
            var res = from emp in xdoc.Root.Elements()
                      where emp.Element("Department").Value == "Accounts"
                      select new
                      {
                          EmployeeName = emp.Element("Name").Value,
                          Designation = emp.Element("Designation").Value,
                          Department = emp.Element("Department").Value,
                          Salary = emp.Element("Salary").Value
                      };
            gv1.DataSource = res;
            gv1.DataBind();

        }
    }
}