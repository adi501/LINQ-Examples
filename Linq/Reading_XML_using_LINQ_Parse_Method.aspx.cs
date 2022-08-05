using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Linq
{
    public partial class Reading_XML_using_LINQ_Parse_Method : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Parse(@"
                <Employees>
                    <Employee>
                        <Name>Balu</Name>
                        <Designation>Executive</Designation>
                        <Department>Accounts</Department>
                        <Salary>5000</Salary>
                    </Employee>
                    <Employee>
                        <Name>Nani</Name>
                        <Designation>Manager</Designation>
                        <Department>Accounts</Department>
                        <Salary>24000</Salary>
                    </Employee>
                    <Employee>
                        <Name>Naga</Name>
                        <Designation>Manager</Designation>
                        <Department>Finance</Department>
                        <Salary>28000</Salary>
                    </Employee>
                    <Employee>
                        <Name>Reddy</Name>
                        <Designation>Analyst</Designation>
                        <Department>Finance</Department>
                        <Salary>21000</Salary>
                    </Employee>
                </Employees>
                ");
            var res = from emp in xdoc.Root.Elements()
                      select new
                      {
                          EmployeeName = emp.Element("Name").Value,
                          Department = emp.Element("Department").Value,
                          Salary = emp.Element("Salary").Value
                      };
            gv1.DataSource = res;
            gv1.DataBind();

        }
    }
}