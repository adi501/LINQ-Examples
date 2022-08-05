using System;
using System.Linq;

namespace Linq
{
    public partial class LINQ_Query_Contains : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            var employees = from emps in sqlObj.tblDepartments
                            where emps.Name.Contains("I")
                            select new
                            {
                                emps.Id,
                                emps.Name
                            };
            gv1.DataSource = employees;
            gv1.DataBind();


        }
    }
}